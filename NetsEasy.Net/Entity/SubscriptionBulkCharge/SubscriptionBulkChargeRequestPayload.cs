using System.Collections.Generic;
using System.Text.Json.Serialization;
using NetEasy.Entity.Common;

namespace NetEasy.Entity.SubscriptionBulkCharge
{
    public class SubscriptionBulkChargeRequestPayload
    {
        /// <summary>
        ///     A string that uniquely identifies the bulk charge operation. Use this property for enabling safe retries. Must be
        ///     between 1 and 64 characters.
        /// </summary>
        [JsonPropertyName("externalBulkChargeId")]
        public string ExternalBulkChargeId { get; set; }

        /// <summary>
        ///     Notifications allow you to subscribe to status updates for a payment.
        /// </summary>
        [JsonPropertyName("notifications")]
        public Notifications Notifications { get; set; }

        /// <summary>
        ///     The array of subscriptions that should be charged. Each item in the array should define either a subscriptionId or
        ///     an externalReference, but not both.
        /// </summary>
        [JsonPropertyName("subscriptions")]
        public List<Subscription> Subscriptions { get; set; }
    }
}