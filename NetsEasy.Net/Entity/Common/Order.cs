using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace NetEasy.Entity.Common
{
    public class Order
    {
        [JsonPropertyName("items")]
        public List<OrderItem> Items { get; set; }

        [JsonPropertyName("amount")]
        public int Amount { get; set; }

        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        [JsonPropertyName("reference")]
        public string Reference { get; set; }
    }
}