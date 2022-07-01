using System.Text.Json.Serialization;

namespace NetEasy.Entity.Common
{
    public class Header
    {
        [JsonPropertyName("string")]
        public string String { get; set; }
    }
}