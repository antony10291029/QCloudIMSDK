 

using Newtonsoft.Json;
 

namespace QCloudIMSDK.models.message.contents
{
	 
	public class FaceMsgContent : MsgContent
	{
         
	    [JsonProperty("Index")]
	    public   int Index { get; set; }

        [JsonProperty("Data")]
        public   string Data { get; set; }
	}

}