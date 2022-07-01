using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace NetEasy.Entity.SubscriptionGetBulkCharges
{
    public class SubscriptionGetBulkChargesResponsePayload
    {
        [JsonPropertyName("page")]
        public List<PageItem> Page { get; set; }

        /// <summary>
        ///     Indicates whether there are more subscriptions beyond the requested range.
        /// </summary>
        [JsonPropertyName("more")]
        public bool More { get; set; }

        /// <summary>
        ///     Indicates whether the operation has completed or is still processing subscriptions. Possible values are 'Done' and
        ///     'Processing'.
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}