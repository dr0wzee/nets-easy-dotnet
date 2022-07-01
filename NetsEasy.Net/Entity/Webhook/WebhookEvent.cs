namespace NetEasy.Entity.Webhook
{
    /// <summary>
    ///     payment.created	A payment has been created.
    ///     payment.reservation.created.v2 The amount of the payment has been reserved.
    ///     payment.checkout.completed The customer has completed the checkout.
    ///     payment.charge.created.v2 The customer has successfully been charged, partially or fully.
    ///     payment.charge.failed A charge attempt has failed.
    ///     payment.refund.initiated.v2 A refund has been initiated.
    ///     payment.refund.failed A refund attempt has failed.
    ///     payment.refund.completed A refund has successfully been completed.
    ///     payment.cancel.created A reservation has been canceled.
    ///     payment.cancel.failed A cancellation has failed.
    /// </summary>
    public sealed class WebHookEvent
    {
        public const string PaymentChargeCreated = "payment.charge.created.v2";
        public const string PaymentCreated = "payment.created";
        public const string PaymentReservationCreated = "payment.reservation.created";
        public const string PaymentReservationFailed = "payment.reservation.failed";
        public const string PaymentCheckoutCompleted = "payment.checkout.completed";
        public const string PaymentChargeFailed = "payment.charge.failed";
    }
}