

using QCloudIMSDK.models.member;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace QCloudIMSDK.models.groups
{
	 
	public class GetJoinedGroupListResult : QCloudIMResult
	{
        
	    [JsonProperty("TotalCount")]
        public  long TotalCount { get; set; }

	    [JsonProperty("GroupIdList")]
        public  IList<GroupId> GroupIdList { get; set; }
	}

}