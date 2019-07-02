

using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace QCloudIMSDK.models.groups
{

    public class GetGroupShuttedUinResult : QCloudIMResult
    {
        [JsonProperty("GroupId")]
        public string GroupId { get; set; }

        [JsonProperty("ShuttedUinList")]
        public IList<ShuttedUinItem> ShuttedUinList { get; set; }
    }
    public class ShuttedUinItem
    {

        [JsonProperty("Member_Account")]
        public string MemberAccount { get; set; }

        [JsonProperty("ShuttedUntil")]
        public long ShuttedUntil { get; set; }
    }
}