using System.Text.Json.Serialization;

namespace NetEasy.Entity.PaymentCreate
{
    public class TextOptions
    {
        [JsonPropertyName("completePaymentButtonText")]
        public string CompletePaymentButtonText { get; set; }
    }
}