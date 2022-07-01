using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using NetEasy.Entity.ReportPayoutDetails;
using NetEasy.Entity.ReportPayouts;

namespace NetEasy
{
    public class ReportingApi : Service
    {
        public ReportingApi(ClientConfiguration configuration) : base(configuration)
        {
            //
        }

        /// <summary>
        ///     GET /report/v1/payouts
        ///     Retrieves the payouts for a given date range. This method supports pagination. Specify the range of payouts to
        ///     retrieve by using pageNumber together with pageSize. The total number of payouts is /// /// returned in the
        ///     response property named numberOfPayouts, which you can use to decide if there are more payouts beyond the requested
        ///     range.
        ///     Responses
        ///     200 SUCCESS
        ///     - numberOfPayouts integer (int32) optional The total number of payouts matching the specified date and currency
        ///     criteria in the request. Use this property to decided if there are more items to fetch beyond the requested range.
        ///     - payouts array optional The array of payouts objects.
        ///     400 Bad Request
        ///     401 Unauthorized
        ///     404 Resource Not Found
        ///     500 Unexpected Error
        /// </summary>
        /// <param name="fromDate">
        ///     string (date) required The starting date of the report period, for example '2018-01-01'. Should
        ///     be formatted according to the definition of full-date in RFC3339.
        /// </param>
        /// <param name="toDate">
        ///     string (date) required The ending date of the report period, for example '2018-12-31'. Should be
        ///     formatted according to the definition of full-date in RFC3339.
        /// </param>
        /// <param name="merchantNumber">
        ///     integer (int64) optional The merchant number. Use this parameter only if you are a Nets
        ///     partner using the service with your partner API key.
        /// </param>
        /// <param name="currency">
        ///     string optional Include only payouts with the specified currency. If not specified, payouts of
        ///     all currencies are returned. Should be formatted according to an ISO 4217 3-letter currency code, for example
        ///     'SEK'.
        /// </param>
        /// <param name="pageNumber">
        ///     integer (int32) optional The page number to be retrieved (zero-based). Default value is 0
        ///     (first page). See also pageSize.
        /// </param>
        /// <param name="pageSize"> integer (int32) optional The size of each page. Default value is 100. See also pageNumber.</param>
        /// <returns>PayoutsGetResponsePayload</returns>
        public Task<PayoutsGetResponsePayload> ReportPayoutsGetAsync(DateTime fromDate, DateTime toDate, long? merchantNumber, string currency, int? pageNumber, int? pageSize)
        {
            var builder = new StringBuilder($"/report/v1/payouts?fromDate={fromDate:yyyy-MM-dd}&toDate={toDate:yyyy-MM-dd}");
            if (merchantNumber.HasValue)
                builder.Append($"&merchantNumber={merchantNumber}");
            if (!string.IsNullOrEmpty(currency))
                builder.Append($"&currency={currency}");
            if (pageNumber.HasValue)
                builder.Append($"&pageNumber={pageNumber}");
            if (pageSize.HasValue)
                builder.Append($"&pageSize={pageSize}");

            return CallAsync<PayoutsGetResponsePayload>(builder.ToString(), HttpMethod.Get);
        }

        /// <summary>
        ///     Retrieve payout details
        ///     GET /report/v1/payouts/{id}
        ///     Retrieves details for the specified payout. A payout always relates to one or more payment actions. The payment
        ///     actions are included in the response and support pagination. Specify the range of /// /// actions to retrieve by
        ///     using pageNumber together with pageSize. The total number of payment actions is returned in the response property
        ///     named numberOfPaymentActions which you can use to decided if /// there are more items beyond the requested range.
        ///     Responses
        ///     200 SUCCESS
        ///     id string optional The unique payout identifier (a UUID).
        ///     reference string optional The reference used on bank account statements.
        ///     date string optional The date of the payout, for example '2021-03-21'. Should be formatted according to the
        ///     definition of full-date in RFC3339.
        ///     bankAccountIban string optional The IBAN (International Bank Account Number) of the bank account that the payout
        ///     was addressed to.
        ///     bankAccountBic string optional The BIC (Business Identifier Code) of the bank that holds the account that received
        ///     the payout from Nets.
        ///     currency string optional The currency of the payout formatted according to an ISO 4217 3-letter currency code, for
        ///     example 'SEK'.
        ///     amount integer (int64) optional The amount that was paid to you, specified in the lowest monetary unit. For
        ///     example, 9.99 USD is specified as 999.
        ///     chargedAmount integer (int64) optional The amount that your customer was charged. Specified in the lowest monetary
        ///     unit, for example, 9.99 USD is specified as 999.
        ///     refundedAmount integer (int64) optional The amount that was refunded to your customer. Specified in the lowest
        ///     monetary unit, for example, 9.99 USD is specified as 999.
        ///     depositedAmount integer (int64) optional The amount that was deposited by you. Specified in the lowest monetary
        ///     unit, for example, 9.99 USD is specified as 999.
        ///     fees integer (int64) optional The total amount of all fees added to the payment actions.
        ///     feeVATpercent integer (int64) deprecated
        ///     feeTaxRate integer (int64) optional Always 0 (zero) since there is no taxation on the fees. (Replaces the
        ///     deprecated property feeVATpercent)
        ///     feeTaxAmount integer (int64) optional Always 0 (zero) since there is no taxation on the fees.
        ///     transactionTaxDetails array optional A list of tax details for the payments related to this payout. Contains
        ///     multiple elements in case tax rates vary.
        ///     numberOfPaymentActions integer (int32) optional The total number of payment actions in this settlement. Use this
        ///     property to decide if there are more items to retrieve beyond the requested range.
        ///     paymentActions array optional The list payment actions associated with this payout. Supports pagination by
        ///     specifying pageNumber and pageSize in the request. See also numberOfPaymentActions.
        ///     400 Bad Request
        ///     401 Unauthorized
        ///     404 Resource Not Found
        ///     500 Unexpected Error
        /// </summary>
        /// <param name="id"> string required The unique identifier (a UUID) of the payout.</param>
        /// <param name="merchantNumber">
        ///     integer (int64) required The merchant number. Use this parameter only if you are a Nets
        ///     partner and uses the service with your partner API key.
        /// </param>
        /// <param name="pageNumber">
        ///     integer (int32) optional The page number of the list of payment actions to be retrieved
        ///     (zero-based). Default value is 0 (first page). See also pageSize.
        /// </param>
        /// <param name="pageSize">
        ///     integer (int32) optional The number of payment actions to be returned in each page. Default
        ///     value is 100. See also pageNumber.
        /// </param>
        /// <returns>PayoutDetailsGetResponsePayload</returns>
        public Task<PayoutDetailsGetResponsePayload> ReportPayoutDetailsGetAsync(string id, long? merchantNumber, int? pageNumber, int? pageSize)
        {
            var builder = new StringBuilder($"/report/v1/payouts/{id}?");
            if (merchantNumber.HasValue)
                builder.Append($"&merchantNumber={merchantNumber}");
            if (pageNumber.HasValue)
                builder.Append($"&pageNumber={pageNumber}");
            if (pageSize.HasValue)
                builder.Append($"&pageSize={pageSize}");

            return CallAsync<PayoutDetailsGetResponsePayload>(builder.ToString(), HttpMethod.Get);
        }
    }
}