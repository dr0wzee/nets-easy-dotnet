using System.Text.Json.Serialization;

namespace NetEasy.Entity.PaymentGet
{
    public class Checkout
    {
        [JsonPropertyName("url")]
        public string Url { get; set; }
    }
}