using System.Text.Json.Serialization;

namespace NetEasy.Entity.PaymentCreate
{
    public class Company
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("contact")]
        public Contact Contact { get; set; }
    }
}