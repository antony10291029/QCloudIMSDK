 
using QCloudIMSDK.models.message.contents;
using Newtonsoft.Json;
 

namespace QCloudIMSDK.models.message
{


    public class MsgBodyItem
    {
        [JsonProperty("MsgType")]
        public   string MsgType { get; set; }

        [JsonProperty("MsgContent")]
        public   MsgContent MsgContent { get; set; }
    }

}