using System.Text.Json.Serialization;

namespace NetEasy.Entity.PaymentCreate
{
    public class Consumer
    {
        [JsonPropertyName("reference")]
        public string Reference { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("shippingAddress")]
        public ShippingAddress ShippingAddress { get; set; }

        [JsonPropertyName("phoneNumber")]
        public PhoneNumber PhoneNumber { get; set; }

        [JsonPropertyName("privatePerson")]
        public PrivatePerson PrivatePerson { get; set; }

        [JsonPropertyName("company")]
        public Company Company { get; set; }
    }
}