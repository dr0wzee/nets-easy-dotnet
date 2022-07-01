using System.Text.Json.Serialization;

namespace NetEasy.Entity.SubscriptionGet
{
    public class CardDetails
    {
        [JsonPropertyName("expiryDate")]
        public string ExpiryDate { get; set; }

        [JsonPropertyName("maskedPan")]
        public string MaskedPan { get; set; }
    }
}