
using Newtonsoft.Json;


namespace QCloudIMSDK.models.ologin
{

    public class AccountImportRequest : QCloudIMRequest
    {

        private string _nick;
        private string _faceUrl;
        private string _identifier;

        public AccountImportRequest(string requestIdentifier, string identifier, string nick, string faceUrl) : base(requestIdentifier)
        {

            this._nick = nick;
            this._faceUrl = faceUrl;
            this._identifier = identifier;
        }

        public AccountImportRequest() : base()
        {
        }

        [JsonProperty("Nick")]
        public virtual string Nick
        {
            get
            {
                return _nick;
            }
            set
            {
                this._nick = value;
            }
        }

        [JsonProperty("FaceUrl")]
        public virtual string FaceUrl
        {
            get
            {
                return _faceUrl;
            }
            set
            {
                this._faceUrl = value;
            }
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