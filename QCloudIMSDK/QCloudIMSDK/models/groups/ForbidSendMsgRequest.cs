using System.Collections.Generic;
using Newtonsoft.Json;

namespace QCloudIMSDK.models.groups
{
 
	public class ForbidSendMsgRequest : QCloudIMRequest
	{
        
	    [JsonProperty("GroupId")]
        public  string GroupId { get; set; }

	    [JsonProperty("Members_Account")]
        public  IList<string> MemberAccount { get; set; }

	    [JsonProperty("ShutUpTime")]
        public  int ShutUpTime { get; set; }
	}

}