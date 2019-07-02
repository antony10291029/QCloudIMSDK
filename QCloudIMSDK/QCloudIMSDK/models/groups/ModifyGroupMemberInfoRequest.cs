

using QCloudIMSDK.models.member;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace QCloudIMSDK.models.groups
{


    public class ModifyGroupMemberInfoRequest : QCloudIMRequest
    {
        [JsonProperty("GroupId")]
        public string GroupId { get; set; }

        [JsonProperty("Member_Account")]
        public string MemberAccount { get; set; }

        [JsonProperty("Role")]
        public string Role { get; set; }

        [JsonProperty("MsgFlag")]
        public string MsgFlag { get; set; }

        [JsonProperty("NameCard")]
        public string NameCard { get; set; }

        [JsonProperty("AppMemberDefinedData")]
        public IList<AppDefinedData> AppDefinedData { get; set; }
    }

}