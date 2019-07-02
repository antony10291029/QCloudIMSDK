using QCloudIMSDK.models.portrait;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace QCloudIMSDK.models.profile
{
	 
	public class PortraitSetRequest : QCloudIMRequest
	{
        
	    [JsonProperty("From_Account")]
        public virtual string FromAccount { get; set; }

        [JsonProperty("ProfileItem")]
	    public virtual IList<ProfileItem> TagList { get; set; }
	}

}