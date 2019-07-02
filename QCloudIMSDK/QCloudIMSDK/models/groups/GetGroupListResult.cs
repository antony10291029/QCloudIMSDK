
using System.Collections.Generic;
using QCloudIMSDK.models.member;
using Newtonsoft.Json;

namespace QCloudIMSDK.models.groups
{
	 
	public class GetGroupListResult : QCloudIMResult
	{
         
	    [JsonProperty("GroupIdList")]
        public IList<GroupId> GroupIdList { get; set; }
	    [JsonProperty("Next")]
        public long Next { get; set; }
	    [JsonProperty("TotalCount")]
        public long TotalCount { get; set; }
	}

}