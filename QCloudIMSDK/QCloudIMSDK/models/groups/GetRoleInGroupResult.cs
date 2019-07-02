

using System.Collections.Generic;
using Newtonsoft.Json;

namespace QCloudIMSDK.models.groups
{

    public class GetRoleInGroupResult : QCloudIMResult
    {
        [JsonProperty("UserIdList")]
        public IList<UserId> UserIdList { get; set; }
    }
    public class UserId
    {
        [JsonProperty("Member_Account")]
        public string MemberAccount { get; set; }
        [JsonProperty("Role")]

        public string Role { get; set; }
    }
}