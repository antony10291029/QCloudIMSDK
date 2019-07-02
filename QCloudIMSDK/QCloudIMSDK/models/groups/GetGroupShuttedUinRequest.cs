using Newtonsoft.Json;

namespace QCloudIMSDK.models.groups
{
	
	public class GetGroupShuttedUinRequest : QCloudIMRequest
	{
        
	    [JsonProperty("GroupId")]
        public  string GroupId { get; set; }
	}

}