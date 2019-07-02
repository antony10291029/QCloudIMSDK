 
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace QCloudIMSDK.models.member
{
 
	public class AppDefinedData
	{
 
        [JsonProperty("Key")]
	    public virtual string Key { get; set; }

	    [JsonProperty("Value")]
        public virtual string Value { get; set; }
	}

}