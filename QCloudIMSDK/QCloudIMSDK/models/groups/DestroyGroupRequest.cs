
using Newtonsoft.Json;

namespace QCloudIMSDK.models.groups
{
	 
	public class DestroyGroupRequest : QCloudIMRequest
	{
        
	    [JsonProperty("GroupId")]
        public  string GroupId { get; set; }
	}

}