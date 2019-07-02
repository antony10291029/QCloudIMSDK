using Newtonsoft.Json;

namespace QCloudIMSDK.models.groups
{
	
	public class CreateGroupResult : QCloudIMResult
	{
       
	    [JsonProperty("GroupId")]
        public  string GroupId { get; set; }
	}

}