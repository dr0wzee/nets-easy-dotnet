using System.Text.Json.Serialization;

namespace NetEasy.Entity.PaymentGet
{
    public class PaymentGetResponsePayload
    {
        /// <summary>
        ///     Contains all information about a payment.
        /// </summary>
        [JsonPropertyName("payment")]
        public Payment Payment { get; set; }
    }
}