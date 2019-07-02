 

using System.Collections.Generic;
using Newtonsoft.Json;
 

namespace QCloudIMSDK.models.ologin
{
	 
	public class MultiAccountImportResult : QCloudIMResult
	{
	    public MultiAccountImportResult() : base()
		{
		}

        [JsonProperty("FailAccounts")]
		public virtual IList<string> FailAccounts { get; set; }
	}

}