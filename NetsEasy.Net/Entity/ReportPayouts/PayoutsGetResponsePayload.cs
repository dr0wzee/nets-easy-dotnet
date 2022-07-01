using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace NetEasy.Entity.ReportPayouts
{
    public class PayoutsGetResponsePayload
    {
        [JsonPropertyName("numberOfPayouts")]
        public int NumberOfPayouts { get; set; }

        [JsonPropertyName("payouts")]
        public List<Payout> Payouts { get; set; }
    }
}