using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using NetEasy.Entity.Common;

namespace NetEasy.Entity.ReportPayoutDetails
{
    public class PaymentActionEntry
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("paymentId")]
        public string PaymentId { get; set; }

        [JsonPropertyName("paymentAction")]
        public string PaymentAction { get; set; }

        [JsonPropertyName("paymentMethod")]
        public string PaymentMethod { get; set; }

        [JsonPropertyName("paymentType")]
        public string PaymentType { get; set; }

        [JsonPropertyName("timestamp")]
        public DateTime Timestamp { get; set; }

        [JsonPropertyName("reference")]
        public string Reference { get; set; }

        [JsonPropertyName("invoiceNumber")]
        public string InvoiceNumber { get; set; }

        [JsonPropertyName("amount")]
        public int Amount { get; set; }

        [JsonPropertyName("vatAmount")]
        public int VatAmount { get; set; }

        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        [JsonPropertyName("fee")]
        public int Fee { get; set; }

        [JsonPropertyName("flexibleFee")]
        public int FlexibleFee { get; set; }

        [JsonPropertyName("fixedFee")]
        public int FixedFee { get; set; }

        [JsonPropertyName("feeVATpercent")]
        public int FeeVatPercent { get; set; }

        [JsonPropertyName("feeTaxRate")]
        public int FeeTaxRate { get; set; }

        [JsonPropertyName("feeTaxAmount")]
        public int FeeTaxAmount { get; set; }

        [JsonPropertyName("transactionTaxDetails")]
        public List<TransactionTaxDetail> TransactionTaxDetails { get; set; }

        [JsonPropertyName("subscriptionId")]
        public string SubscriptionId { get; set; }
    }
}