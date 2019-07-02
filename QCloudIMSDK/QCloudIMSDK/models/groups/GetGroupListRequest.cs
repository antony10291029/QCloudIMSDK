﻿using Newtonsoft.Json;

namespace QCloudIMSDK.models.groups
{
	 
	public class GetGroupListRequest : QCloudIMRequest
	{
       
	    [JsonProperty("Limit")]
        public  long? Limit { get; set; }

	    [JsonProperty("Next")]
        public  long? Next { get; set; }

	    [JsonProperty("GroupType")]
        public  string GroupType { get; set; }
	}

}