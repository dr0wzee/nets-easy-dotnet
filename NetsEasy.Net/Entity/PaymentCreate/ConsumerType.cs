using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace NetEasy.Entity.PaymentCreate
{
    public class ConsumerType
    {
        [JsonPropertyName("default")]
        public string Default { get; set; }

        [JsonPropertyName("supportedTypes")]
        public List<string> SupportedTypes { get; set; }
    }
}