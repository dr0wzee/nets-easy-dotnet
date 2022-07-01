using System.Text.Json.Serialization;

namespace NetEasy.Entity.Webhook
{
    public class WebHookPayloadDataThreeDSecure
    {
        [JsonPropertyName("acsUrl")]
        public string AcsUrl { get; set; }

        [JsonPropertyName("authenticationEnrollmentStatus")]
        public string AuthenticationEnrollmentStatus { get; set; }

        [JsonPropertyName("authenticationStatus")]
        public string AuthenticationStatus { get; set; }

        [JsonPropertyName("eci")]
        public string Eci { get; set; }
    }
}