 
using Newtonsoft.Json;
 

namespace QCloudIMSDK.models.message.contents
{
	 

	public class CustomMsgContent : MsgContent
	{
         
	    [JsonProperty("Data")]
        public  string Data { get; set; }
	    [JsonProperty("Desc")]

        public  string Desc { get; set; }

	    [JsonProperty("Ext")]
        public  string Ext { get; set; }

        [JsonProperty("Sound")]
	    public  string Sound { get; set; }
	}

}