
using System.Collections.Generic;
using Newtonsoft.Json;

namespace QCloudIMSDK.models.config
{
 
	public class GetAppInfoRequest : QCloudIMRequest
	{
 
	 
        [JsonProperty("RequestField")]
        public  IList<string> RequestField
		{
            get;set;
		}

	}

}