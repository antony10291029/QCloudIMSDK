using System.Collections.Generic;
using QCloudIMSDK.models.member;
using Newtonsoft.Json;

namespace QCloudIMSDK.models.groups
{
	 

	public class GetGroupMemberInfoResult : QCloudIMResult
	{
         
	    [JsonProperty("MemberNum")]
        public  int MemberNum { get; set; }

	    [JsonProperty("MemberList")]
        public  IList<MemberListResultItem> MemberList { get; set; }
	}

}