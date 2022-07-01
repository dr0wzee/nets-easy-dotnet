using System.Collections.Generic;
using System.Text.Json.Serialization;
using NetEasy.Entity.Common;

namespace NetEasy.Entity.ReportPayouts
{
    public class Payout
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("reference")]
        public string Reference { get; set; }

        [JsonPropertyName("date")]
        public string Date { get; set; }

        [JsonPropertyName("bankAccountIban")]
        public string BankAccountIban { get; set; }

        [JsonPropertyName("bankAccountBic")]
        public string BankAccountBic { get; set; }

        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        [JsonPropertyName("amount")]
        public int Amount { get; set; }

        [JsonPropertyName("chargedAmount")]
        public int ChargedAmount { get; set; }

        [JsonPropertyName("refundedAmount")]
        public int RefundedAmount { get; set; }

        [JsonPropertyName("depositedAmount")]
        public int DepositedAmount { get; set; }

        [JsonPropertyName("numberOfCharges")]
        public int NumberOfCharges { get; set; }

        [JsonPropertyName("fees")]
        public int Fees { get; set; }

        [JsonPropertyName("feeVATpercent")]
        public int FeeVATpercent { get; set; }

        [JsonPropertyName("feeTaxRate")]
        public int FeeTaxRate { get; set; }

        [JsonPropertyName("feeTaxAmount")]
        public int FeeTaxAmount { get; set; }

        [JsonPropertyName("transactionTaxDetails")]
        public List<TransactionTaxDetail> TransactionTaxDetails { get; set; }
    }
}