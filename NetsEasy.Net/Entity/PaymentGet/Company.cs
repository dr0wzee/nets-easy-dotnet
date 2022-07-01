using System.Text.Json.Serialization;

namespace NetEasy.Entity.PaymentGet
{
    public class Company
    {
        [JsonPropertyName("merchantReference")]
        public string MerchantReference { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("registrationNumber")]
        public string RegistrationNumber { get; set; }

        [JsonPropertyName("contactDetails")]
        public ContactDetails ContactDetails { get; set; }
    }
}