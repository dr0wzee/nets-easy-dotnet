using System.Text.Json.Serialization;

namespace NetEasy.Entity.Common
{
    public class OrderItem
    {
        [JsonPropertyName("reference")]
        public string Reference { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("quantity")]
        public int Quantity { get; set; }

        [JsonPropertyName("unit")]
        public string Unit { get; set; }

        [JsonPropertyName("unitPrice")]
        public int UnitPrice { get; set; }

        [JsonPropertyName("taxRate")]
        public int TaxRate { get; set; }

        [JsonPropertyName("taxAmount")]
        public int TaxAmount { get; set; }

        [JsonPropertyName("grossTotalAmount")]
        public int GrossTotalAmount { get; set; }

        [JsonPropertyName("netTotalAmount")]
        public int NetTotalAmount { get; set; }
    }
}