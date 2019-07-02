using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace QCloudIMSDK.utils
{
    public class TlsSignature
    {
        static string pri_key_path = @"QCloud\keys\private_key.pem";
        private static string LoadPrivateKeyFile()
        {
            string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            pri_key_path = pri_key_path.Replace("~/", "").TrimStart('/').Replace('/', '\\');
            try
            {
                using (FileStream f = new FileStream(Path.Combine(baseDirectory, pri_key_path), FileMode.Open,FileAccess.Read))
                {
                    BinaryReader reader = new BinaryReader(f);
                    byte[] b = new byte[f.Length];
                    reader.Read(b, 0, b.Length);
                    return Encoding.Default.GetString(b);
                }
            }
            catch (Exception  )
            {
                // ignored
                return string.Empty;
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sdkAppId"></param>
        /// <param name="identifier"></param>
        /// <param name="privStr"></param>
        /// <returns></returns>
        public static GenTLSSignatureResult GenTLSSignatureEx(string sdkAppId, String identifier, String privStr = "")
        {
            if (string.IsNullOrWhiteSpace(privStr))
            {
                privStr = LoadPrivateKeyFile();
            }
            GenTLSSignatureResult result = new GenTLSSignatureResult();
            //return genTLSSignatureEx(sdkAppId, identifier, privStr, 3600*24*180);
            StringBuilder sig = new StringBuilder(4096);
            StringBuilder errMsg = new StringBuilder(4096);
            int ret = sigcheck.tls_gen_sig_ex(
                Convert.ToUInt32(sdkAppId),
                identifier,
                sig,
                4096,
                privStr,
                (UInt32)privStr.Length,
                errMsg,
                4096);
            if (0 != ret)
            {
                result.ErrMessage = errMsg.ToString();
            }
            else
            {
                result.UrlSig = sig.ToString();
            }
            return result;
        }
        //public void test()
        //{
        //    FileStream f = new FileStream(pri_key_path, FileMode.Open, FileAccess.Read);
        //    BinaryReader reader = new BinaryReader(f);
        //    byte[] b = new byte[f.Length];
        //    reader.Read(b, 0, b.Length);
        //    string pri_key = Encoding.Default.GetString(b);

        //    StringBuilder sig = new StringBuilder(4096);
        //    StringBuilder err_msg = new StringBuilder(4096);
        //    int ret = sigcheck.tls_gen_sig_ex(
        //        1400065611,
        //        "blackadmin ",
        //        sig,
        //        4096,
        //        pri_key,
        //        (UInt32)pri_key.Length,
        //        err_msg,
        //        4096);
        //    if (0 != ret)
        //    {

        //        return;
        //    }

        //    // 校验 sig
        //    f = new FileStream(pub_key_path, FileMode.Open, FileAccess.Read);
        //    reader = new BinaryReader(f);
        //    b = new byte[f.Length];
        //    reader.Read(b, 0, b.Length);
        //    string pub_key = Encoding.Default.GetString(b);

        //    UInt32 expire_time = 0;
        //    UInt32 init_time = 0;
        //    ret = sigcheck.tls_vri_sig_ex(
        //        sig.ToString(),
        //        pub_key,
        //        (UInt32)pub_key.Length,
        //        1400065611,
        //        "blackadmin ",
        //        ref expire_time,
        //        ref init_time,
        //        err_msg,
        //        4096);

        //    if (0 != ret)
        //    {

        //        return;
        //    }


        //}
    }
    public class GenTLSSignatureResult
    {
        public String ErrMessage { get; set; }
        public String UrlSig { get; set; }
        public int ExpireTime { get; set; }
        public int InitTime { get; set; }

    }
    public static class dllpath
    {
        // 开发者调用 dll 时请注意项目的平台属性，下面的路径是 demo 创建时使用的，请自己使用予以修改
        // 请使用适当的平台 dll
        //public const string DllPath = @"D:\src\oicq64\tinyid\tls_sig_api\windows\64\lib\libsigcheck\sigcheck.dll";       // 64 位
        // 如果选择 Any CPU 平台，默认加载 32 位 dll
        // public const string DllPath = @"D:\src\oicq64\tinyid\tls_sig_api\windows\32\lib\libsigcheck\sigcheck.dll";     // 32 位

        public const string DllPath = @"QCloud\sigcheck.dll";


    }

    public class sigcheck
    {
        [DllImport(dllpath.DllPath, EntryPoint = "tls_gen_sig", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public extern static int tls_gen_sig(
            UInt32 expire,
            string appid3rd,
            UInt32 sdkappid,
            string identifier,
            UInt32 acctype,
            StringBuilder sig,
            UInt32 sig_buff_len,
            string pri_key,
            UInt32 pri_key_len,
            StringBuilder err_msg,
            UInt32 err_msg_buff_len
        );

        [DllImport(dllpath.DllPath, EntryPoint = "tls_vri_sig", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public extern static int tls_vri_sig(
            string sig,
            string pub_key,
            UInt32 pub_key_len,
            UInt32 acctype,
            string appid3rd,
            UInt32 sdkappid,
            string identifier,
            StringBuilder err_msg,
            UInt32 err_msg_buff_len
        );

        [DllImport(dllpath.DllPath, EntryPoint = "tls_gen_sig_ex", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public extern static int tls_gen_sig_ex(
            UInt32 sdkappid,
            string identifier,
            StringBuilder sig,
            UInt32 sig_buff_len,
            string pri_key,
            UInt32 pri_key_len,
            StringBuilder err_msg,
            UInt32 err_msg_buff_len
        );

        [DllImport(dllpath.DllPath, EntryPoint = "tls_vri_sig_ex", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public extern static int tls_vri_sig_ex(
            string sig,
            string pub_key,
            UInt32 pub_key_len,
            UInt32 sdkappid,
            string identifier,
            ref UInt32 expire_time,
            ref UInt32 init_time,
            StringBuilder err_msg,
            UInt32 err_msg_buff_len
        );
    }
}
