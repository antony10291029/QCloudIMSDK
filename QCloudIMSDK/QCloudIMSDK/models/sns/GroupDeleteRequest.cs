 
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace QCloudIMSDK.models.sns
{
	 
	public class GroupDeleteRequest : QCloudIMRequest
	{
 

            [JsonProperty("From_Account")]
	    public   string FromAccount { get; set; }

	    [JsonProperty("GroupName")]
        public   IList<string> GroupName { get; set; }
	}

}