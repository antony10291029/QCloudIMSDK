﻿using Newtonsoft.Json;

namespace QCloudIMSDK.models.groups
{
	 
	public class DeleteGroupMsgBySenderRequest : QCloudIMRequest
	{
        
	    [JsonProperty("GroupId")]
        public  string GroupId { get; set; }

	    [JsonProperty("Sender_Account")]
        public  string SenderAccount { get; set; }
	}

}