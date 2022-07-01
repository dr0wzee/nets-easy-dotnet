using System.Collections.Generic;
using System.Text.Json.Serialization;
using NetEasy.Entity.Common;

namespace NetEasy.Entity.PaymentGet
{
    public class Refunds
    {
        [JsonPropertyName("amount")]
        public int Amount { get; set; }

        [JsonPropertyName("lastUpdated")]
        public string LastUpdated { get; set; }

        [JsonPropertyName("orderItems")]
        public List<OrderItem> OrderItems { get; set; }

        [JsonPropertyName("refundId")]
        public string RefundId { get; set; }

        [JsonPropertyName("state")]
        public string State { get; set; }
    }
}