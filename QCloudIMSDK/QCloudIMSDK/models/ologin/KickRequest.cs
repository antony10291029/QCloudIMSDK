 

using Newtonsoft.Json;

namespace QCloudIMSDK.models.ologin
{
	 
	public class KickRequest : QCloudIMRequest
	{
  
		private string _identifier;

		public KickRequest(string requestIdentifier, string identifier) : base(requestIdentifier)
		{

			this._identifier = identifier;
		}

		public KickRequest() : base()
		{
		}

	    [JsonProperty("Identifier")]
        public virtual string Identifier
		{
			get
			{
				return _identifier;
			}
			set
			{
				this._identifier = value;
			}
		}

	}

}