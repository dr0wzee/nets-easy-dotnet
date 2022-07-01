using System.Text.Json.Serialization;

namespace NetEasy.Entity.PaymentCreate
{
    public class DisplayOptions
    {
        [JsonPropertyName("showMerchantName")]
        public bool ShowMerchantName { get; set; }

        [JsonPropertyName("showOrderSummary")]
        public bool ShowOrderSummary { get; set; }
    }
}