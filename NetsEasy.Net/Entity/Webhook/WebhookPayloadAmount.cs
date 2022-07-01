using System.Text.Json.Serialization;

namespace NetEasy.Entity.Webhook
{
    public class WebHookPayloadAmount
    {
        [JsonPropertyName("amount")]
        public int Amount { get; set; }

        [JsonPropertyName("currency")]
        public string Currency { get; set; }
    }
}