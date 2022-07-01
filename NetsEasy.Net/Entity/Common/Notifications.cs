using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace NetEasy.Entity.Common
{
    public class Notifications
    {
        [JsonPropertyName("webHooks")]
        public List<WebHook> WebHooks { get; set; }
    }
}