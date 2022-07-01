using System.Text.Json.Serialization;

namespace NetEasy.Entity.PaymentCreate
{
    public class Country
    {
        [JsonPropertyName("countryCode")]
        public string CountryCode { get; set; }
    }
}