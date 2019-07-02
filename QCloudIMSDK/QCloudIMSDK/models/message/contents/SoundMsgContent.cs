 
using Newtonsoft.Json;

namespace QCloudIMSDK.models.message.contents
{
	 
	public class SoundMsgContent : MsgContent
	{
    

	    [JsonProperty("UUID")]
	    public  string Uuid { get; set; }


	    [JsonProperty("Size")]
	    public  long Size { get; set; }

        [JsonProperty("Second")]
	    public  int Seconds { get; set; }
	}

}