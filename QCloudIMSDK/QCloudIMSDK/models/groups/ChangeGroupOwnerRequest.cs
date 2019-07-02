using Newtonsoft.Json;

namespace QCloudIMSDK.models.groups
{
 
	public class ChangeGroupOwnerRequest : QCloudIMRequest
	{
        
	    [JsonProperty("GroupId")]
        public  string GroupId { get; set; }

	    [JsonProperty("NewOwner_Account")]
        public  string NewOwnerAccount { get; set; }
	}

}