using Newtonsoft.Json;

namespace QCloudIMSDK .models
{
 
    /// <summary>
    /// 
    /// </summary>
	public class QCloudIMRequest
	{
	    public QCloudIMRequest(string reqIdentifier)
		{
			this.ReqIdentifier = reqIdentifier;
		}

		public QCloudIMRequest()
		{

		}
	    [JsonProperty("reqIdentifier"),JsonIgnore]
        public  string ReqIdentifier { get; set; }

	    [JsonProperty("usersig"), JsonIgnore]
        public  string UserSig
		{
			get;set;
			 
		}

	    [JsonProperty("sdkappid"), JsonIgnore]
        public  string AppId
		{
	        get; set;
        }

	    [JsonProperty("random"), JsonIgnore]
        public  string Random
		{
	        get; set;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
		public  string ToJsonString()
		{
			return JsonConvert.SerializeObject(this) ;
		}
	}

}