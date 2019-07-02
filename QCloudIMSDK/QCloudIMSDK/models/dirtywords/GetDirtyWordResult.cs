﻿ 

using System.Collections.Generic;
using Newtonsoft.Json;

namespace QCloudIMSDK.models.dirtywords
{
	 
	public class GetDirtyWordResult : QCloudIMResult
	{ 
            [JsonProperty("DirtyWordsList")]
	    public virtual IList<string> DirtyWordsList { get; set; }
	}

}