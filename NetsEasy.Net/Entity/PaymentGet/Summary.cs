using System.Text.Json.Serialization;

namespace NetEasy.Entity.PaymentGet
{
    public class Summary
    {
        /// <summary>
        ///     The amount that has been canceled. See also the Cancel payment method.
        /// </summary>
        [JsonPropertyName("cancelledAmount")]
        public int CancelledAmount { get; set; }

        /// <summary>
        ///     The charged amount. See also the Charge payment method.
        /// </summary>
        [JsonPropertyName("chargedAmount")]
        public int ChargedAmount { get; set; }

        /// <summary>
        ///     The amount that has been refunded. See also the Refund payment method.
        /// </summary>
        [JsonPropertyName("refundedAmount")]
        public int RefundedAmount { get; set; }

        /// <summary>
        ///     The amount that has been reserved in the customer's bank account at the time of the purchase to make sure there are
        ///     sufficient funds to charge the payment. See also the Create payment method.
        /// </summary>
        [JsonPropertyName("reservedAmount")]
        public int ReservedAmount { get; set; }
    }
}