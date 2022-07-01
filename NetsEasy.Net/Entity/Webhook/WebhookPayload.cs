using System;
using System.Text.Json.Serialization;

namespace NetEasy.Entity.Webhook
{
    public class WebHookPayload
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("merchantId")]
        public int MerchantId { get; set; }

        [JsonPropertyName("timestamp")]
        public DateTime Timestamp { get; set; }

        [JsonPropertyName("event")]
        public string Event { get; set; }

        [JsonPropertyName("data")]
        public WebHookPayloadData Data { get; set; }
    }
}