 

using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace QCloudIMSDK.models.openim
{
 
	public class QueryStateRequest : QCloudIMRequest
	{
 
		private IList<string> toAccount;

		public QueryStateRequest(string reqIdentifier, IList<string> toAccount) : base(reqIdentifier)
		{
			this.toAccount = toAccount;
		}

		public QueryStateRequest(IList<string> toAccount)
		{
			this.toAccount = toAccount;
		}

        [JsonProperty("To_Account")]
		public  IList<string> ToAccount
		{
			get
			{
				return toAccount;
			}
			set
			{
				this.toAccount = value;
			}
		}

	}

}