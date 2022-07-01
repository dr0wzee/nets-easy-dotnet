using System;
using System.Text.Json.Serialization;

namespace NetEasy.Entity.PaymentCreate
{
    public class Subscription
    {
        /// <summary>
        ///     (uuid) The identifier of the subscription to be updated. If omitted, a new subscription will be created.
        /// </summary>
        [JsonPropertyName("subscriptionId")]
        public string SubscriptionId { get; set; }

        /// <summary>
        ///     The date and time when the subscription expires. It is not possible to charge this subscription after this date.
        ///     The field has three components: date, time, and time zone (offset from GMT). For example:
        ///     2021-07-02T12:00:00.0000+02:00
        /// </summary>
        [JsonPropertyName("endDate")]
        public DateTime EndDate { get; set; }

        /// <summary>
        ///     Defines the minimum number of days between each recurring charge. This interval commences from either the day the
        ///     subscription was created or the most recent subscription charge, whichever is later. An interval value of 0 means
        ///     that there are no payment interval restrictions.
        /// </summary>
        [JsonPropertyName("interval")]
        public int Interval { get; set; }
    }
}