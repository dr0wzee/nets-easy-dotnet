using System.Text.Json.Serialization;

namespace NetEasy.Entity.PaymentGet
{
    public class OrderDetails
    {
        [JsonPropertyName("amount")]
        public int Amount { get; set; }

        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        [JsonPropertyName("reference")]
        public string Reference { get; set; }
    }
}