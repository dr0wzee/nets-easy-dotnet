using System.Text.Json.Serialization;

namespace NetEasy.Entity.PaymentGet
{
    public class PhoneNumber
    {
        [JsonPropertyName("prefix")]
        public string Prefix { get; set; }

        [JsonPropertyName("number")]
        public string Number { get; set; }
    }
}