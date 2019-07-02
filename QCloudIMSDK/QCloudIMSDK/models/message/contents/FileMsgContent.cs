 

using Newtonsoft.Json;

namespace QCloudIMSDK.models.message.contents
{
	 
	public class FileMsgContent : MsgContent
	{
 

	    [JsonProperty("UUID")]
	    public  string Uuid { get; set; }

	    [JsonProperty("FileSize")]
        public  long FileSize { get; set; }

	    [JsonProperty("FileName")]
        public  string Filename { get; set; }
	}

}