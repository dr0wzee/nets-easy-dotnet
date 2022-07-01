using System.Text.Json.Serialization;

namespace NetEasy.Entity.PaymentGet
{
    public class ContactDetails
    {
        [JsonPropertyName("firstName")]
        public string FirstName { get; set; }

        [JsonPropertyName("lastName")]
        public string LastName { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("phoneNumber")]
        public PhoneNumber PhoneNumber { get; set; }
    }
}