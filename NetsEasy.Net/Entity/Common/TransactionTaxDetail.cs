using System.Text.Json.Serialization;

namespace NetEasy.Entity.Common
{
    public class TransactionTaxDetail
    {
        [JsonPropertyName("rate")]
        public int Rate { get; set; }

        [JsonPropertyName("amount")]
        public int Amount { get; set; }
    }
}