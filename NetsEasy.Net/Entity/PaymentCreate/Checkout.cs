using System.Text.Json.Serialization;

namespace NetEasy.Entity.PaymentCreate
{
    public class Checkout
    {
        [JsonPropertyName("charge")]
        public bool Charge { get; set; }

        [JsonPropertyName("publicDevice")]
        public bool PublicDevice { get; set; }

        [JsonPropertyName("integrationType")]
        public string IntegrationType { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonPropertyName("returnUrl")]
        public string ReturnUrl { get; set; }

        [JsonPropertyName("termsUrl")]
        public string TermsUrl { get; set; }

        [JsonPropertyName("appearance")]
        public Appearance Appearance { get; set; }

        [JsonPropertyName("merchantHandlesConsumerData")]
        public bool MerchantHandlesConsumerData { get; set; }

        [JsonPropertyName("consumer")]
        public Consumer Consumer { get; set; }

        [JsonPropertyName("consumerType")]
        public ConsumerType ConsumerType { get; set; }

        [JsonPropertyName("merchantHandlesShippingCost")]
        public bool MerchantHandlesShippingCost { get; set; }

        [JsonPropertyName("shipping")]
        public Shipping Shipping { get; set; }
    }
}