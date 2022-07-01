using System.Net.Http;
using System.Threading.Tasks;
using NetEasy.Entity.PaymentCharge;
using NetEasy.Entity.PaymentCreate;
using NetEasy.Entity.PaymentGet;
using NetEasy.Entity.SubscriptionBulkCharge;
using NetEasy.Entity.SubscriptionGet;
using NetEasy.Entity.SubscriptionGetBulkCharges;

namespace NetEasy
{
    public class PaymentApi : Service
    {
        public PaymentApi(ClientConfiguration configuration) : base(configuration)
        {
            //
        }

        public Task<PaymentCreateResponsePayload> PaymentCreateAsync(PaymentCreateRequestPayload payload)
        {
            return CallAsync<PaymentCreateResponsePayload>("/v1/payments/", HttpMethod.Post, JsonContent(payload));
        }

        public Task<PaymentGetResponsePayload> PaymentGetAsync(string paymentId)
        {
            return CallAsync<PaymentGetResponsePayload>($"/v1/payments/{paymentId}", HttpMethod.Get);
        }

        public Task<PaymentChargeResponsePayload> PaymentChargeAsync(string paymentId, PaymentChargeRequestPayload payload)
        {
            return CallAsync<PaymentChargeResponsePayload>($"/v1/payments/{paymentId}/charges", HttpMethod.Post, JsonContent(payload));
        }

        public Task<SubscriptionGetResponsePayload> SubscriptionGetAsync(string subscriptionId)
        {
            return CallAsync<SubscriptionGetResponsePayload>($"/v1/subscriptions/{subscriptionId}", HttpMethod.Get);
        }

        public Task<SubscriptionGetResponsePayload> SubscriptionGetByExternalReferenceAsync(string externalReferenceId)
        {
            return CallAsync<SubscriptionGetResponsePayload>($"/v1/subscriptions?externalReference={externalReferenceId}", HttpMethod.Get);
        }

        public Task<SubscriptionBulkChargeResponsePayload> SubscriptionBulkChargeAsync(SubscriptionBulkChargeRequestPayload payload)
        {
            return CallAsync<SubscriptionBulkChargeResponsePayload>("/v1/subscriptions/charges", HttpMethod.Post, JsonContent(payload));
        }

        /// <summary>
        ///     GET /v1/subscriptions/charges/{bulkId}
        ///     Retrieves charges associated with the specified bulk charge operation. The bulkId is returned from Nets in the
        ///     response of the Bulk charge subscriptions method.
        ///     This method supports pagination. Specify the range of subscriptions to retrieve by using either skip and take or
        ///     pageNumber together with pageSize. The boolean property named more in the response body, indicates whether there
        ///     are more subscriptions beyond the requested range.
        /// </summary>
        /// <param name="bulkId">
        ///     The identifier of the bulk charge operation that was returned from the Bulk charge subscriptions
        ///     method.
        /// </param>
        /// <param name="skip">
        ///     The number of subscription entries to skip from the start. Use this property in combination with the
        ///     take property.
        /// </param>
        /// <param name="take">
        ///     The maximum number of subscriptions to be retrieved. Use this property in combination with the skip
        ///     property.
        /// </param>
        /// <returns></returns>
        public Task<SubscriptionGetBulkChargesResponsePayload> SubscriptionGetBulkChargesAsync(string bulkId, int skip, int take)
        {
            return CallAsync<SubscriptionGetBulkChargesResponsePayload>($"/v1/subscriptions/charges/{bulkId}?skip={skip}&take={take}", HttpMethod.Get);
        }
    }
}