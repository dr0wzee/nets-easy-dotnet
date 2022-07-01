using System.Text.Json.Serialization;

namespace NetEasy.Entity.SubscriptionBulkCharge
{
    public class SubscriptionBulkChargeResponsePayload
    {
        /// <summary>
        ///     The bulk charge identifier (a UUID). This identifier can be used when retrieving all charges associated with a bulk
        ///     charge operation.
        /// </summary>
        [JsonPropertyName("bulkId")]
        public string BulkId { get; set; }
    }
}