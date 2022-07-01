using System.Text.Json.Serialization;

namespace NetEasy.Entity.Webhook
{
    public class WebHookPayloadDataCardDetails
    {
        [JsonPropertyName("creditDebitIndicator")]
        public string CreditDebitIndicator { get; set; }

        [JsonPropertyName("expiryMonth")]
        public int ExpiryMonth { get; set; }

        [JsonPropertyName("expiryYear")]
        public int ExpiryYear { get; set; }

        [JsonPropertyName("issuerCountry")]
        public string IssuerCountry { get; set; }

        [JsonPropertyName("truncatedPan")]
        public string TruncatedPan { get; set; }

        [JsonPropertyName("threeDSecure")]
        public WebHookPayloadDataThreeDSecure ThreeDSecure { get; set; }
    }
}