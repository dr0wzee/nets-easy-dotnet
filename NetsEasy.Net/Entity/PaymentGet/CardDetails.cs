using System.Text.Json.Serialization;

namespace NetEasy.Entity.PaymentGet
{
    public class CardDetails
    {
        /// <summary>
        ///     A masked version of the PAN (Primary Account Number). At maximum, only the first six and last four digits of the
        ///     account number are displayed
        /// </summary>
        [JsonPropertyName("maskedPan")]
        public string MaskedPan { get; set; }

        /// <summary>
        ///     The four-digit expiration date of the payment card. The format should be: YYMM
        /// </summary>
        [JsonPropertyName("expiryDate")]
        public string ExpiryDate { get; set; }
    }
}