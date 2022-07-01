using System.Collections.Generic;
using System.Text.Json.Serialization;
using NetEasy.Entity.Common;

namespace NetEasy.Entity.PaymentCharge
{
    public class PaymentChargeRequestPayload
    {
        [JsonPropertyName("amount")]
        public int Amount { get; set; }

        [JsonPropertyName("orderItems")]
        public List<OrderItem> OrderItems { get; set; }
    }
}