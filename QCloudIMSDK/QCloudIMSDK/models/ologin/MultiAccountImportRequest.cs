 

using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace QCloudIMSDK.models.ologin
{
 
	public class MultiAccountImportRequest : QCloudIMRequest
	{
 
		private IList<string> _accounts;

		public MultiAccountImportRequest(string requestIdentifier, string identifier, IList<string> accounts) : base(requestIdentifier)
		{

			this._accounts = accounts;
		}

		public MultiAccountImportRequest() : base()
		{
		}

        [JsonProperty("Accounts")]
		public virtual IList<string> Accounts
		{
			get
			{
				return _accounts;
			}
			set
			{
				this._accounts = value;
			}
		}

	}

}