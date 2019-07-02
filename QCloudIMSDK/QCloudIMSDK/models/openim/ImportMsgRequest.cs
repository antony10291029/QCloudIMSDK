﻿ 

using System.Collections.Generic;
using QCloudIMSDK.models.message;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace QCloudIMSDK.models.openim
{
	 
	public class ImportMsgRequest : QCloudIMRequest
	{

            [JsonProperty("SyncFromOldSystem")]
	    public  int SyncFromOldSystem { get; set; }

	    [JsonProperty("From_Account")]
        public  string FromAccount { get; set; }

	    [JsonProperty("To_Account")]
        public  string ToAccount { get; set; }

	    [JsonProperty("MsgRandom")]
        public  int MsgRandom { get; set; }

	    [JsonProperty("MsgTimestamp")]
        public  long MsgTimestamp { get; set; }

	    [JsonProperty("MsgBody")]
        public  IList<MsgBodyItem> MsgBody { get; set; }
	}

}