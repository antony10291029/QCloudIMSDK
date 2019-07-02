﻿using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace QCloudIMSDK.models.sns
{
    public class BlackListGetRequest : QCloudIMRequest
    {

        [JsonProperty("From_Account")]
        public string FromAccount { get; set; }

        [JsonProperty("StartIndex")]
        public int StartIndex { get; set; }

        [JsonProperty("MaxLimited")]
        public int MaxLimited { get; set; }

        [JsonProperty("LastSequence")]
        public long LastSequence { get; set; }
    }

}