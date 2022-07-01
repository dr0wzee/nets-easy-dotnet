using System.Text.Json.Serialization;

namespace NetEasy.Entity.PaymentGet
{
    public class PaymentDetails
    {
        [JsonPropertyName("cardDetails")]
        public CardDetails CardDetails { get; set; }

        [JsonPropertyName("invoiceDetails")]
        public InvoiceDetails InvoiceDetails { get; set; }

        /// <summary>
        ///     The payment method, for example Visa or Mastercard
        /// </summary>
        [JsonPropertyName("paymentMethod")]
        public string PaymentMethod { get; set; }

        /// <summary>
        ///     The type of payment. Possible values are: 'CARD', 'INVOICE', 'A2A', 'INSTALLMENT', 'WALLET', and 'PREPAID-INVOICE'
        /// </summary>
        [JsonPropertyName("paymentType")]
        public string PaymentType { get; set; }
    }
}