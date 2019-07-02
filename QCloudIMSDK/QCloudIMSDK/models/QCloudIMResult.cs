

using Newtonsoft.Json;

namespace QCloudIMSDK.models
{
    /// <summary>
    /// 
    /// </summary>
    public class QCloudIMResult
    {

        public QCloudIMResult()
        {
            
        }
        [JsonProperty("ActionStatus")]
        public string ActionStatus { get; set; }


        [JsonProperty("ErrorInfo")]
        public string ErrorInfo { get; set; }


        [JsonProperty("ErrorCode")]
        public int ErrorCode { get; set; }


        [JsonProperty("ErrorDisplay")]
        public string ErrorDisplay { get; set; }


        [JsonIgnore]
        public bool Success => "OK".Equals(ActionStatus);

        [JsonIgnore]
        public bool Failed => !Success;
    }

}