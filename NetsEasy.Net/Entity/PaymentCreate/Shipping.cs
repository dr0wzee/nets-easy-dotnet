using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace NetEasy.Entity.PaymentCreate
{
    public class Shipping
    {
        [JsonPropertyName("countries")]
        public List<Country> Countries { get; set; }
    }
}