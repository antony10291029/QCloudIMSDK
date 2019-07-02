 

using Newtonsoft.Json;

namespace QCloudIMSDK.models.config
{
	

	public class GetNoSpeakingRequest : QCloudIMRequest
	{
 
        [JsonProperty("Get_Account")]
		public  string GetAccount { get; set; }

	}

}