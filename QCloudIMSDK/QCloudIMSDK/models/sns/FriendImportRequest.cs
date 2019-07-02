

using QCloudIMSDK.models.friend;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace QCloudIMSDK.models.sns
{

    public class FriendImportRequest : QCloudIMRequest
    {
        [JsonProperty("From_Account")]
        public string FromAccount { get; set; }

        [JsonProperty("AddFriendItem")]
        public IList<AddFriendItem> AddFriendItem { get; set; }
    }

}