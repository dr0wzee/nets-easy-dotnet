using System.Text.Json.Serialization;

namespace NetEasy.Entity.Webhook
{
    public class WebHookPayloadData
    {
        [JsonPropertyName("paymentId")]
        public string PaymentId { get; set; }

        [JsonPropertyName("chargeId")]
        public string ChargeId { get; set; }

        [JsonPropertyName("reservationId")]
        public string ReservationId { get; set; }

        [JsonPropertyName("amount")]
        public WebHookPayloadAmount Amount { get; set; }

        [JsonPropertyName("error")]
        public WebhookPayloadDataError Error { get; set; }

        /// <summary>
        /// payment.charge.created
        /// </summary>
        //[JsonPropertyName("orderItems")]
        //public List<WebhookPayloadDataOrderItem> OrderItems { get; set; }

        /// <summary>
        ///     payment.reservation.created
        /// </summary>
        [JsonPropertyName("cardDetails")]
        public WebHookPayloadDataCardDetails CardDetails { get; set; }

        /// <summary>
        ///     payment.reservation.created
        /// </summary>
        [JsonPropertyName("paymentMethod")]
        public string PaymentMethod { get; set; }

        /// <summary>
        ///     payment.reservation.created
        /// </summary>
        [JsonPropertyName("paymentType")]
        public string PaymentType { get; set; }

        /// <summary>
        ///     payment.reservation.created
        /// </summary>
        [JsonPropertyName("consumer")]
        public WebHookPayloadDataConsumer Consumer { get; set; }

        /// <summary>
        ///     payment.reservation.created
        /// </summary>
        [JsonPropertyName("reservationReference")]
        public string ReservationReference { get; set; }

        /// <summary>
        /// payment.created
        /// </summary>
        //[JsonPropertyName("order")]
        //public WebhookPayloadDataOrder Order { get; set; }
    }
}