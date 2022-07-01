using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace NetEasy.Entity.Common
{
    public class WebHook
    {
        [JsonPropertyName("eventName")]
        public string EventName { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("authorization")]
        public string Authorization { get; set; }

        [JsonPropertyName("headers")]
        public List<Header> Headers { get; set; }
    }
}