using System.Text.Json.Serialization;

namespace NetEasy.Entity.PaymentCreate
{
    public class Contact
    {
        [JsonPropertyName("firstName")]
        public string FirstName { get; set; }

        [JsonPropertyName("lastName")]
        public string LastName { get; set; }
    }
}