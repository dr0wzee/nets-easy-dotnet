using System.Text.Json.Serialization;

namespace NetEasy.Entity.PaymentCreate
{
    public class Appearance
    {
        [JsonPropertyName("displayOptions")]
        public DisplayOptions DisplayOptions { get; set; }

        [JsonPropertyName("textOptions")]
        public TextOptions TextOptions { get; set; }
    }
}