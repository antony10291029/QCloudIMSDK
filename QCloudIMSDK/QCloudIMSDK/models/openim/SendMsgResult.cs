

using Newtonsoft.Json;
 

namespace QCloudIMSDK.models.openim
{

    public class SendMsgResult : QCloudIMResult
    {
         
        [JsonProperty("MsgTime")]
        public  long MsgTime { get; set; }
    }


}