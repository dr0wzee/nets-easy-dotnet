using System.Text.Json.Serialization;

namespace NetEasy.Entity.PaymentCreate
{
    public class PaymentCreateResponsePayload
    {
        [JsonPropertyName("paymentId")]
        public string PaymentId { get; set; }

        [JsonPropertyName("hostedPaymentPageUrl")]
        public string HostedPaymentPageUrl { get; set; }
    }
}