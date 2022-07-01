using System;
using System.Text.Json.Serialization;

namespace NetEasy.Entity.PaymentGet
{
    public class Payment
    {
        [JsonPropertyName("checkout")]
        public Checkout Checkout { get; set; }

        [JsonPropertyName("consumer")]
        public Consumer Consumer { get; set; }

        /// <summary>
        ///     The date and time when the payment was initiated
        /// </summary>
        [JsonPropertyName("created")]
        public DateTime Created { get; set; }

        [JsonPropertyName("orderDetails")]
        public OrderDetails OrderDetails { get; set; }

        [JsonPropertyName("paymentDetails")]
        public PaymentDetails PaymentDetails { get; set; }

        /// <summary>
        ///     The payment identifier (a UUID)
        /// </summary>
        [JsonPropertyName("paymentId")]
        public string PaymentId { get; set; }

        /// <summary>
        ///     An array of all the refunds associated with this payment
        /// </summary>
        [JsonPropertyName("refunds")]
        public Refunds Refunds { get; set; }

        /// <summary>
        ///     Summarizes the reserved, charged, refunded, and canceled amounts associated with a payment
        /// </summary>
        [JsonPropertyName("summary")]
        public Summary Summary { get; set; }

        /// <summary>
        ///     The date and time of termination. Only present if the payment has been terminated
        /// </summary>
        [JsonPropertyName("terminated")]
        public DateTime Terminated { get; set; }

        /// <summary>
        ///     The subscription identifier
        /// </summary>
        [JsonPropertyName("subscription")]
        public Subscription Subscription { get; set; }
    }
}