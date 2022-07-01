using System.Text.Json.Serialization;
using NetEasy.Entity.Common;

namespace NetEasy.Entity.SubscriptionBulkCharge
{
    public class Subscription
    {
        /// <summary>
        ///     The subscription identifier (a UUID) returned from the Retrieve payment method. To define the subscriptionID is
        ///     mandatory if externalReference is not defined.
        /// </summary>
        [JsonPropertyName("subscriptionId")]
        public string SubscriptionId { get; set; }

        /// <summary>
        ///     An external reference to identify a set of imported subscriptions. This parameter is only used if your
        ///     subscriptions have been imported from a payment platform other than Nets Easy. To define the externalReference is
        ///     mandatory if no subscriptionID is defined.
        /// </summary>
        [JsonPropertyName("externalReference")]
        public string ExternalReference { get; set; }

        /// <summary>
        ///     Specifies an order associated with a payment. An order must contain at least one order item. The amount of the
        ///     order must match the sum of the specified order items.
        /// </summary>
        [JsonPropertyName("order")]
        public Order Order { get; set; }
    }
}