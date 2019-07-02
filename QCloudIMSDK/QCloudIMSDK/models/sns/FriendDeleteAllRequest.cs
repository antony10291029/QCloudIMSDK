 

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace QCloudIMSDK.models.sns
{
	 
	public class FriendDeleteAllRequest : QCloudIMRequest
	{
        [JsonProperty("From_Account")]
	    public  string FromAccount { get; set; }
	}

}