using QCloudIMSDK.models.friend;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace QCloudIMSDK.models.sns
{
	 
	public class FriendAddRequest : QCloudIMRequest
	{ 

            [JsonProperty("From_Account")]
	    public  string FromAccount { get; set; }

	    [JsonProperty("AddFriendItem")]
        public  IList<AddFriendItem> AddFriendItem { get; set; }

	    [JsonProperty("AddType")]
        public  string AddType { get; set; }

	    [JsonProperty("ForceAddFlags")]
        public  int ForceAddFlags { get; set; }
	}

}