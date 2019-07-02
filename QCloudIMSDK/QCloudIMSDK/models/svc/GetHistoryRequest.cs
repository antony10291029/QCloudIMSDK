 

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace QCloudIMSDK.models.svc
{
	 

	public class GetHistoryRequest : QCloudIMRequest
	{
  
            [JsonProperty("ChatType")]
	    public virtual string ChatType { get; set; }

	    [JsonProperty("MsgTime")]
        public virtual long MsgTime { get; set; }
	}

}