﻿

using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace QCloudIMSDK.models.sns
{

    public class FriendCheckRequest : QCloudIMRequest
    {

        [JsonProperty("From_Account")]
        public string FromAccount { get; set; }

        [JsonProperty("To_Account")]
        public IList<string> ToAccount { get; set; }

        [JsonProperty("CheckType")]
        public string CheckType { get; set; }
    }

}