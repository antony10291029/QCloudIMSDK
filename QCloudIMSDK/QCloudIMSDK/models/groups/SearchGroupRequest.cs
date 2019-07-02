using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace QCloudIMSDK.models.groups
{

    public class SearchGroupRequest : QCloudIMRequest
    {
        [JsonProperty("Content")]
        public string Content { get; set; }

        [JsonProperty("PageNum")]
        public int? PageNum { get; set; }

        [JsonProperty("GroupPerPage")]
        public int? GroupPerPage { get; set; }

        [JsonProperty("ResponseFilter")]
        public SearchGroupResponseFilter ResponseFilter { get; set; }
    }

    public class SearchGroupResponseFilter
    {

        [JsonProperty("GroupBasePublicInfoFilter")]
        public IList<string> GroupBasePublicInfoFilter { get; set; }
    }

}