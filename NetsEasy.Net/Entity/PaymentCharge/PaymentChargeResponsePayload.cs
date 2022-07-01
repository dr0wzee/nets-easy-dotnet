using System.Text.Json.Serialization;

namespace NetEasy.Entity.PaymentCharge
{
    public class PaymentChargeResponsePayload
    {
        [JsonPropertyName("chargeId")]
        public string ChargeId { get; set; }
    }
}