using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace QCloudIMSDK.models.groups
{

    public class SendGroupSystemNotificationRequest : QCloudIMRequest
    {

        [JsonProperty("GroupId")]
        public string GroupId { get; set; }

        [JsonProperty("Content")]
        public string Content { get; set; }

        [JsonProperty("ToMembers_Account")]
        public IList<string> ToMemberAccount { get; set; }
    }

}