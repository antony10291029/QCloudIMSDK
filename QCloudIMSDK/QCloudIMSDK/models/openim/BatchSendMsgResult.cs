 

using System.Collections.Generic;
using QCloudIMSDK.models.message;
using Newtonsoft.Json;
 

namespace QCloudIMSDK.models.openim
{
	　
	public class BatchSendMsgResult : QCloudIMResult
	{ 

            [JsonProperty("ErrorList")]
	    public   IList<ErrorListItem> ErrorList { get; set; }
	}


}