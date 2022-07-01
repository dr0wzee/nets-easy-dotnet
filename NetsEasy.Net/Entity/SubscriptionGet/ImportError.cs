using System.Text.Json.Serialization;

namespace NetEasy.Entity.SubscriptionGet
{
    public class ImportError
    {
        [JsonPropertyName("importStepsResponseCode")]
        public string ImportStepsResponseCode { get; set; }

        [JsonPropertyName("importStepsResponseSource")]
        public string ImportStepsResponseSource { get; set; }

        [JsonPropertyName("importStepsResponseText")]
        public string ImportStepsResponseText { get; set; }
    }
}