 

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace QCloudIMSDK.models.groups
{
	 
	public class ImportGroupResult : QCloudIMResult
	{
 
        [JsonProperty("GroupId")]
	    public  string GroupId { get; set; }
	}

}