using System.Text.Json.Serialization;

namespace NetEasy.Entity.PaymentGet
{
    public class InvoiceDetails
    {
        [JsonPropertyName("dueDate")]
        public string DueDate { get; set; }

        [JsonPropertyName("invoiceNumber")]
        public string InvoiceNumber { get; set; }

        [JsonPropertyName("ocr")]
        public string Ocr { get; set; }

        [JsonPropertyName("pdfLink")]
        public string PdfLink { get; set; }
    }
}