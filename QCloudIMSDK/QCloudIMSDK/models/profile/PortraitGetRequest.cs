﻿using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace QCloudIMSDK.models.profile
{

    public class PortraitGetRequest : QCloudIMRequest
    {

        [JsonProperty("To_Account")]
        public IList<string> ToAccount { get; set; }

        [JsonProperty("TagList")]
        public IList<string> TagList { get; set; }
    }

}