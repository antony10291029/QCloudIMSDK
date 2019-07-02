 

using Newtonsoft.Json;

namespace QCloudIMSDK.models.groups
{
	 
	public class GroupMsgGetSimpleRequest : QCloudIMRequest
	{
         
	    [JsonProperty("GroupId")]
        public  string GroupId { get; set; }

	    [JsonProperty("ReqMsgNumber")]
        public  int ReqMsgNumber { get; set; }

	    [JsonProperty("ReqMsgSeq")]
        public  long? ReqMsgSeq { get; set; }
	}

}