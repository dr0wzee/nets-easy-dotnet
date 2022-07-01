using System.Text.Json.Serialization;

namespace NetEasy.Entity.PaymentGet
{
    public class Consumer
    {
        [JsonPropertyName("shippingAddress")]
        public ShippingAddress ShippingAddress { get; set; }

        [JsonPropertyName("company")]
        public Company Company { get; set; }

        [JsonPropertyName("privatePerson")]
        public PrivatePerson PrivatePerson { get; set; }
    }
}