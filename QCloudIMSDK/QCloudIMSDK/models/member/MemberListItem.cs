﻿

using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace QCloudIMSDK.models.member
{
 

	public class MemberListItem
	{
     
	    [JsonProperty("Name")]
        public virtual string Name { get; set; }

	    [JsonProperty("Role")]
        public virtual string Role { get; set; }

        [JsonProperty("AppMemberDefinedData")]
	    public virtual IList<AppDefinedData> AppMemberDefinedData { get; set; }
	}

}