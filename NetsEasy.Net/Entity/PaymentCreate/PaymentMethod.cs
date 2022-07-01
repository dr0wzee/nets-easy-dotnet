using System.Text.Json.Serialization;

namespace NetEasy.Entity.PaymentCreate
{
    public class PaymentMethod
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("fee")]
        public Fee Fee { get; set; }
    }
}