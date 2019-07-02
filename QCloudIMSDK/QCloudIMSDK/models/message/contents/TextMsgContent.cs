 
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace QCloudIMSDK.models.message.contents
{
	 
	public class TextMsgContent : MsgContent
	{
 
            [JsonProperty("Text")]
	    public   string Text { get; set; }
	}

}