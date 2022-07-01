using System.Text.Json.Serialization;

namespace NetEasy.Entity.SubscriptionGetBulkCharges
{
    public class PageItem
    {
        [JsonPropertyName("subscriptionId")]
        public string SubscriptionId { get; set; }

        [JsonPropertyName("paymentId")]
        public string PaymentId { get; set; }

        [JsonPropertyName("chargeId")]
        public string ChargeId { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("message")]
        public string Message { get; set; }

        [JsonPropertyName("code")]
        public string Code { get; set; }

        [JsonPropertyName("source")]
        public string Source { get; set; }

        [JsonPropertyName("externalReference")]
        public string ExternalReference { get; set; }
    }
}