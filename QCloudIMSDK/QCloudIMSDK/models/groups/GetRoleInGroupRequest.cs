 

using System.Collections.Generic;
using Newtonsoft.Json;

namespace QCloudIMSDK.models.groups
{
 
	public class GetRoleInGroupRequest : QCloudIMRequest
	{
      
	    [JsonProperty("GroupId")]
        public  string GroupId { get; set; }

	    [JsonProperty("User_Account")]
        public  IList<string> UserAccount { get; set; }
	}

}