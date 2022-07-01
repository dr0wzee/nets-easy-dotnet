using System.Text.Json.Serialization;

namespace NetEasy.Entity.PaymentGet
{
    public class Subscription
    {
        /// <summary>
        ///     The subscription identifier (a UUID)
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }
    }
}