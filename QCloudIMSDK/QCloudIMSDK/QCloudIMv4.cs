using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Configuration;
using System.Threading.Tasks;
using QCloudIMSDK.models;
using QCloudIMSDK.utils;
using Newtonsoft.Json;
using RestSharp;

using QCloudIMSDK.models.config;
using QCloudIMSDK.models.dirtywords;
using QCloudIMSDK.models.groups;
using QCloudIMSDK.models.ologin;
using QCloudIMSDK.models.openim;
using QCloudIMSDK.models.profile;
using QCloudIMSDK.models.sns;
using QCloudIMSDK.models.svc;

namespace QCloudIMSDK
{
    public class QCloudIMv4
    {
        private const string ApiUrl = "https://console.tim.qq.com/v4/";
        private static readonly string AppId;

        static string GlobalRequestIdentifier { get; set; }

        static QCloudIMv4()
        {
            Configuration config = System.Configuration.ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
             GlobalRequestIdentifier = config.AppSettings.Settings["QIM.Identifier"].Value;
             AppId = config.AppSettings.Settings["QIM.IMAppid"].Value;

        }
        /// <summary>
        ///私有构造函数
        /// </summary>
        private QCloudIMv4()
        {

        }

        /// <summary>
        /// 拼接restful的url参数
        /// </summary>
        /// <param name="serviceName"></param>
        /// <param name="actionName"></param>
        /// <param name="request"></param>
        /// <returns></returns>
        private static string MakeApiUrl(string serviceName, string actionName, QCloudIMRequest request)
        {

            return serviceName + "/" + actionName + "?usersig=" + request.UserSig + "&identifier=" +
                   request.ReqIdentifier + "&sdkappid=" + request.AppId + "&random=" + request.Random + "&contenttype=json";

        }
        /// <summary>
        /// 获取签名
        /// </summary>
        /// <param name="identifier"></param>
        /// <returns></returns>
        public static string MakeUserSig(string identifier)
        {
            return TlsSignature.GenTLSSignatureEx(AppId, identifier).UrlSig;
        }

        private static T Request<T>(string serviceName, string actionName, QCloudIMRequest request) where T : QCloudIMResult, new()
        {
            RestRequest restrequest;
            var client = GetRestSharpClient(serviceName, actionName, request, out restrequest);

            var response = client.Execute<T>(restrequest);


            //if (response.StatusCode != "OK")
            //{
            //    throw new YCException("Failed to request QCloud IM API " + actionName + ": " + response.ErrorInfo);
            //}

            return JsonConvert.DeserializeObject<T>(response.Content);
        }

        private void RequestAsync(string serviceName, string actionName, QCloudIMRequest request)
        {
            RestRequest restrequest;
            var client = GetRestSharpClient(serviceName, actionName, request, out restrequest);

            var result = client.ExecuteTaskAsync<QCloudIMResult>(restrequest).Result;


        }
        private static RestClient GetRestSharpClient(string serviceName, string actionName, QCloudIMRequest request, out RestRequest restrequest)
        {
            request.AppId = AppId;
            request.Random = Math.Abs(new Random().Next()).ToString();
            if (string.IsNullOrWhiteSpace(request.ReqIdentifier))
            {
                request.ReqIdentifier = GlobalRequestIdentifier;
            }
            try
            {
                string userSig = MakeUserSig(request.ReqIdentifier);
                request.UserSig = userSig;
            }
            catch (Exception ex)
            {
                throw new Exception("Failed to generate signature for " + serviceName + " " + actionName + " " +
                                      request.ReqIdentifier, ex);
            }
            string url = MakeApiUrl(serviceName, actionName, request);
            RestClient client = new RestClient(baseUrl: ApiUrl);
            restrequest = new RestRequest(url, Method.POST);
            restrequest.AddHeader("Content-Type", "application/json"); //设置HTTP头

            var jSetting = new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore };
            string jsonToSend = JsonConvert.SerializeObject(request, Formatting.Indented, jSetting);
            
            restrequest.AddParameter("application/json; charset=utf-8", jsonToSend, "application/json;charset=UTF-8",
                ParameterType.RequestBody);
            restrequest.RequestFormat = DataFormat.Json;
            return client;
        }

        #region IMOpenLoginSvc  
        public static AccountImportResult AccountImport(AccountImportRequest request)
        {
            return Request<AccountImportResult>("im_open_login_svc", "account_import", request);
        }
        public virtual MultiAccountImportResult MultiAccountImport(MultiAccountImportRequest request)
        {
            return Request<MultiAccountImportResult>("im_open_login_svc", "multiaccount_import", request);
        }
        public virtual KickResult Kick(KickRequest request)
        {
            return Request<KickResult>("im_open_login_svc", "kick", request);
        }
        public virtual RegisterAccountResult RegisterAccount(RegisterAccountRequest request)
        {
            return Request<RegisterAccountResult>("im_open_login_svc", "register_account_v1", request);
        }
        #endregion

        #region OpenIM 
        public virtual SendMsgResult SendMsg(SendMsgRequest request)
        {
            return Request<SendMsgResult>("openim", "sendmsg", request);
        }
        public virtual BatchSendMsgResult BatchSendMsg(BatchSendMsgRequest request)
        {
            return Request<BatchSendMsgResult>("openim", "batchsendmsg", request);
        }
        public virtual ImportMsgResult ImportMsg(ImportMsgRequest request)
        {
            return Request<ImportMsgResult>("openim", "importmsg", request);
        }
        public virtual QueryStateResult QueryState(QueryStateRequest request)
        {
            return Request<QueryStateResult>("openim", "querystate", request);
        }

        #endregion

        #region  Profile
        public virtual PortraitGetResult PortraitGet(PortraitGetRequest request)
        {
            return Request<PortraitGetResult>("profile", "portrait_get", request);
        }


        public virtual PortraitSetResult PortraitSet(PortraitSetRequest request)
        {
            return Request<PortraitSetResult>("profile", "portrait_set", request);
        }

        #endregion

        #region SNS
        public virtual FriendAddResult FriendAdd(FriendAddRequest request)
        {
            return Request<FriendAddResult>("sns", "friend_add", request);
        }



        public virtual FriendImportResult FriendImport(FriendImportRequest request)
        {
            return Request<FriendImportResult>("sns", "friend_import", request);
        }


        public virtual FriendDeleteResult FriendDelete(FriendDeleteRequest request)
        {
            return Request<FriendDeleteResult>("sns", "friend_delete", request);
        }



        public virtual FriendDeleteAllResult FriendDeleteAll(FriendDeleteAllRequest request)
        {
            return Request<FriendDeleteAllResult>("sns", "friend_delete_all", request);
        }



        public virtual FriendCheckResult FriendCheck(FriendCheckRequest request)
        {
            return Request<FriendCheckResult>("sns", "friend_check", request);
        }



        public virtual FriendGetAllResult FriendGetAll(FriendGetAllRequest request)
        {
            return Request<FriendGetAllResult>("sns", "friend_get_all", request);
        }



        public virtual FriendGetListResult FriendGetList(FriendGetListRequest request)
        {
            return Request<FriendGetListResult>("sns", "friend_get_list", request);
        }


        public virtual BlackListAddResult BlackListAdd(BlackListAddRequest request)
        {
            return Request<BlackListAddResult>("sns", "black_list_add", request);
        }



        public virtual BlackListDeleteResult BlackListDelete(BlackListDeleteRequest request)
        {
            return Request<BlackListDeleteResult>("sns", "black_list_delete", request);
        }



        public virtual BlackListGetResult BlackListGet(BlackListGetRequest request)
        {
            return Request<BlackListGetResult>("sns", "black_list_get", request);
        }



        public virtual BlackListCheckResult BlackListCheck(BlackListCheckRequest request)
        {
            return Request<BlackListCheckResult>("sns", "black_list_check", request);
        }



        public virtual GroupAddResult GroupAdd(GroupAddRequest request)
        {
            return Request<GroupAddResult>("sns", "group_add", request);
        }



        public virtual GroupDeleteResult GroupDelete(GroupDeleteRequest request)
        {
            return Request<GroupDeleteResult>("sns", "group_delete", request);
        }


        #endregion

        #region GroupOpenSvc
        public static CreateGroupResult CreateGroup(CreateGroupRequest request)
        {
            return Request<CreateGroupResult>("group_open_http_svc", "create_group", request);
        }

        public static GetGroupListResult GetGroupList(GetGroupListRequest request)
        {
            return Request<GetGroupListResult>("group_open_http_svc", "get_appid_group_list", request);
        }
        public static GetGroupInfoResult GetGroupInfo(GetGroupInfoRequest request)
        {
            return Request<GetGroupInfoResult>("group_open_http_svc", "get_group_info", request);
        }
        public static GetGroupMemberInfoResult GetGroupMemberInfo(GetGroupMemberInfoRequest request)
        {
            return Request<GetGroupMemberInfoResult>("group_open_http_svc", "get_group_member_info", request);
        }
        public static ModifyGroupBaseInfoResult ModifyGroupBaseInfo(ModifyGroupBaseInfoRequest request)
        {
            return Request<ModifyGroupBaseInfoResult>("group_open_http_svc", "modify_group_base_info", request);
        }

        public static AddGroupMemberResult AddGroupMember(AddGroupMemberRequest request)
        {
            return Request<AddGroupMemberResult>("group_open_http_svc", "add_group_member", request);
        }
        public static DeleteGroupMemberResult DeleteGroupMember(DeleteGroupMemberRequest request)
        {
            return Request<DeleteGroupMemberResult>("group_open_http_svc", "delete_group_member", request);
        }
        public static ModifyGroupMemberInfoResult ModifyGroupMemberInfo(ModifyGroupMemberInfoRequest request)
        {
            return Request<ModifyGroupMemberInfoResult>("group_open_http_svc", "modify_group_member_info", request);
        }
        public static DestroyGroupResult DestroyGroup(DestroyGroupRequest request)
        {
            return Request<DestroyGroupResult>("group_open_http_svc", "destroy_group", request);
        }
        public static GetJoinedGroupListResult GetJoinedGroupList(GetJoinedGroupListRequest request)
        {
            return Request<GetJoinedGroupListResult>("group_open_http_svc", "get_joined_group_list", request);
        }

        public static GetRoleInGroupResult GetRoleInGroup(GetRoleInGroupRequest request)
        {
            return Request<GetRoleInGroupResult>("group_open_http_svc", "get_role_in_group", request);
        }
        public static ForbidSendMsgResult ForbidSendMsg(ForbidSendMsgRequest request)
        {
            return Request<ForbidSendMsgResult>("group_open_http_svc", "forbid_send_msg", request);
        }
        public static GetGroupShuttedUinResult GetGroupShuttedUin(GetGroupShuttedUinRequest request)
        {
            return Request<GetGroupShuttedUinResult>("group_open_http_svc", "get_group_shutted_uin", request);
        }
        public static SendGroupMsgResult SendGroupMsg(SendGroupMsgRequest request)
        {
            return Request<SendGroupMsgResult>("group_open_http_svc", "send_group_msg", request);
        }
        public static SendGroupSystemNotificationResult SendGroupSystemNotification(SendGroupSystemNotificationRequest request)
        {
            return Request<SendGroupSystemNotificationResult>("group_open_http_svc", "send_group_system_notification", request);
        }
        public static ChangeGroupOwnerResult ChangeGroupOwner(ChangeGroupOwnerRequest request)
        {
            return Request<ChangeGroupOwnerResult>("group_open_http_svc", "change_group_owner", request);
        }
        public static ImportGroupResult ImportGroup(ImportGroupRequest request)
        {
            return Request<ImportGroupResult>("group_open_http_svc", "import_group", request);
        }
        public static ImportGroupMsgResult ImportGroupMsg(ImportGroupMsgRequest request)
        {
            return Request<ImportGroupMsgResult>("group_open_http_svc", "import_group_msg", request);
        }
        public static ImportGroupMemberResult ImportGroupMember(ImportGroupMemberRequest request)
        {
            return Request<ImportGroupMemberResult>("group_open_http_svc", "import_group_member", request);
        }
        public static SetUnreadMsgNumResult SetUnreadMsgNum(SetUnreadMsgNumRequest request)
        {
            return Request<SetUnreadMsgNumResult>("group_open_http_svc", "set_unread_msg_num", request);
        }
        public static DeleteGroupMsgBySenderResult DeleteGroupMsgBySender(DeleteGroupMsgBySenderRequest request)
        {
            return Request<DeleteGroupMsgBySenderResult>("group_open_http_svc", "delete_group_msg_by_sender", request);
        }
        public static SearchGroupResult SearchGroup(SearchGroupRequest request)
        {
            return Request<SearchGroupResult>("group_open_http_svc", "search_group", request);
        }
        public static GroupMsgGetSimpleResult GroupMsgGetSimple(GroupMsgGetSimpleRequest request)
        {
            return Request<GroupMsgGetSimpleResult>("group_open_http_svc", "group_msg_get_simple", request);
        }
        #endregion

        #region OpenIMDirtyWords
        public virtual GetDirtyWordResult Get(GetDirtyWordRequest request)
        {
            return Request<GetDirtyWordResult>("openim_dirty_words", "get", request);
        }

        public virtual AddDirtyWordResult Add(AddDirtyWordRequest request)
        {
            return Request<AddDirtyWordResult>("openim_dirty_words", "add", request);
        }

        public virtual DeleteDirtyWordResult Delete(DeleteDirtyWordRequest request)
        {
            return Request<DeleteDirtyWordResult>("openim_dirty_words", "delete", request);
        }

        #endregion

        #region OpenConfigSvr
        public virtual SetNoSpeakingResult SetNoSpeaking(SetNoSpeakingRequest request)
        {
            return Request<SetNoSpeakingResult>("openconfigsvr", "setnospeaking", request);
        }

        public virtual GetNoSpeakingResult GetNoSpeaking(GetNoSpeakingRequest request)
        {
            return Request<GetNoSpeakingResult>("openconfigsvr", "getnospeaking", request);
        }

        public virtual GetAppInfoResult GetAppInfo(GetAppInfoRequest request)
        {
            return Request<GetAppInfoResult>("openconfigsvr", "getappinfo", request);
        }
        #endregion

        #region OpenMsgSvc
        public virtual GetHistoryResult GetHistory(GetHistoryRequest request)
        {
            return Request<GetHistoryResult>("open_msg_svc", "get_history", request);
        }
        #endregion
    }
}
