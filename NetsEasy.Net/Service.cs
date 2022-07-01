using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace NetEasy
{
    public class Service
    {
        private static readonly JsonSerializerOptions DefaultJsonSerializerOptions = new JsonSerializerOptions
        {
            AllowTrailingCommas = true,
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
            IncludeFields = true
        };

        protected readonly ClientConfiguration Configuration;

        public Service(ClientConfiguration configuration)
        {
            Configuration = configuration;
        }

        private HttpClient HttpClient => Configuration.HttpClient ?? DefaultHttpClient.Instance;

        protected StringContent JsonContent<T>(T payload)
        {
            var content = JsonSerializer.Serialize(payload, DefaultJsonSerializerOptions);
            return new StringContent(content, Encoding.UTF8, "application/json");
        }

        protected async Task<T> CallAsync<T>(string path, HttpMethod method, HttpContent content = null)
        {
            var url = Configuration.BaseUrl.SimpleCombineUrl(path);

            var request = new HttpRequestMessage(method, url);
            request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            request.Headers.Add("Authorization", Configuration.SecretKey);
            request.Content = content;

            using (var response = await HttpClient.SendAsync(request))
            {
                if (response.IsSuccessStatusCode)
                {
                    var payloadStream = await response.Content.ReadAsStreamAsync();
                    var responsePayload = await JsonSerializer.DeserializeAsync<T>(payloadStream, DefaultJsonSerializerOptions);
                    return responsePayload;
                }

                throw await RestApiException.FromHttpResponseMessageAsync(response);
            }
        }
    }
}