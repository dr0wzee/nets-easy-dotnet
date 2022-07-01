using System.Collections.Generic;
using System.Text.Json.Serialization;
using NetEasy.Entity.Common;

namespace NetEasy.Entity.PaymentCreate
{
    /// <summary>
    ///     https://nets-devs.isotop.se/nets-easy/en-EU/api/payment-v1/#v1-payments-post
    /// </summary>
    public class PaymentCreateRequestPayload
    {
        /// <summary>
        ///     Specifies an order associated with a payment. An order must contain at least one order item. The amount of the
        ///     order must match the sum of the specified order items.
        /// </summary>
        [JsonPropertyName("order")]
        public Order Order { get; set; }

        /// <summary>
        ///     The merchant number. Use this header only if you are a Nets partner and initiating the checkout with your partner
        ///     keys. If you are using the integration keys for your webshop, there is no need to specify this header.
        /// </summary>
        [JsonPropertyName("merchantNumber")]
        public int? MerchantNumber { get; set; }

        /// <summary>
        ///     Defines the behavior and style of the checkout page.
        /// </summary>
        [JsonPropertyName("checkout")]
        public Checkout Checkout { get; set; }

        /// <summary>
        ///     The list of webhooks. The maximum number of webhooks is 32.
        /// </summary>
        [JsonPropertyName("notifications")]
        public Notifications Notifications { get; set; }

        /// <summary>
        ///     Specifies an array of invoice fees added to the total price when invoice is used as the payment method.
        /// </summary>
        [JsonPropertyName("paymentMethods")]
        public List<PaymentMethod> PaymentMethods { get; set; }

        /// <summary>
        ///     Defines the duration and interval when creating or updating a subscription.
        ///     https://nets-devs.isotop.se/nets-easy/en-EU/api/payment-v1/#subscriptions
        /// </summary>
        [JsonPropertyName("subscription")]
        public Subscription Subscription { get; set; }
    }
}