using System.Collections.Generic;
using Newtonsoft.Json;

namespace QCloudIMSDK.models.groups
{
	 
	public class AddGroupMemberResult : QCloudIMResult
	{
		
 
	    [JsonProperty("MemberList")]
        public  IList<MemberListItem> MemberList { get; set; }
	}
   

}