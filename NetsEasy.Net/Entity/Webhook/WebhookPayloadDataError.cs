using System.Text.Json.Serialization;

namespace NetEasy.Entity.Webhook
{
    public class WebhookPayloadDataError
    {
        [JsonPropertyName("code")]
        public string Code { get; set; }

        [JsonPropertyName("message")]
        public string Message { get; set; }

        [JsonPropertyName("source")]
        public string Source { get; set; }
    }
}