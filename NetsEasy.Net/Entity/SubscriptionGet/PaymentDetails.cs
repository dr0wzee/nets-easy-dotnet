using System.Text.Json.Serialization;

namespace NetEasy.Entity.SubscriptionGet
{
    public class PaymentDetails
    {
        [JsonPropertyName("paymentType")]
        public string PaymentType { get; set; }

        [JsonPropertyName("paymentMethod")]
        public string PaymentMethod { get; set; }

        [JsonPropertyName("cardDetails")]
        public CardDetails CardDetails { get; set; }
    }
}