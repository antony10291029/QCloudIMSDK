﻿

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace QCloudIMSDK.models.config
{


    public class SetNoSpeakingRequest : QCloudIMRequest
    {

        [JsonProperty("Set_Account")]
        public virtual string SetAccount { get; set; }

        [JsonProperty("C2CmsgNospeakingTime")]
        public virtual long C2CMsgNoSpeakingTime { get; set; }

        [JsonProperty("GroupmsgNospeakingTime")]
        public virtual long GroupMsgNoSpeakingTime { get; set; }
    }

}