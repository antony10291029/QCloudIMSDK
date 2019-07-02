 

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace QCloudIMSDK.models.sns
{
	 
	public class GroupDeleteResult : QCloudIMResult
	{
 
            [JsonProperty("CurrentSequence")]
	    public virtual int CurrentSequence { get; set; }
	}

}