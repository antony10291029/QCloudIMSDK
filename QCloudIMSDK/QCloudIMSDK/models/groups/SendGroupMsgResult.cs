

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace QCloudIMSDK.models.groups
{

    public class SendGroupMsgResult : QCloudIMResult
    {
        [JsonProperty("MsgTime")]
        public long MsgTime { get; set; }

        [JsonProperty("MsgSeq")]

        public int MsgSeq { get; set; }
    }

}