using System;
using System.Text.Json.Serialization;

namespace NetEasy.Entity.SubscriptionGet
{
    public class SubscriptionGetResponsePayload
    {
        [JsonPropertyName("subscriptionId")]
        public string SubscriptionId { get; set; }

        [JsonPropertyName("interval")]
        public int Interval { get; set; }

        [JsonPropertyName("endDate")]
        public DateTime EndDate { get; set; }

        [JsonPropertyName("paymentDetails")]
        public PaymentDetails PaymentDetails { get; set; }

        [JsonPropertyName("importError")]
        public ImportError ImportError { get; set; }
    }
}