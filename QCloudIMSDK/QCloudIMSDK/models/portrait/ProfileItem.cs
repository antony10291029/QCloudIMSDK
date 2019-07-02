 

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace QCloudIMSDK.models.portrait
{
 
	public class ProfileItem
	{
 

            [JsonProperty("Tag")]
	    public  string Tag { get; set; }

	    [JsonProperty("Value")]
        public  string Value { get; set; }
	}

}