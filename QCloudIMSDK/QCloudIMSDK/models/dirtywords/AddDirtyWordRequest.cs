
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace QCloudIMSDK.models.dirtywords
{
	 
	public class AddDirtyWordRequest : QCloudIMRequest
	{
 
        [JsonProperty("DirtyWordsList")]
	    public virtual IList<string> DirtyWordsList { get; set; }
	}

}