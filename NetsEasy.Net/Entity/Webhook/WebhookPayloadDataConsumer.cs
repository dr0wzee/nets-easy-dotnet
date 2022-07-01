using System.Text.Json.Serialization;

namespace NetEasy.Entity.Webhook
{
    public class WebHookPayloadDataConsumer
    {
        [JsonPropertyName("ip")]
        public string Ip { get; set; }
    }
}