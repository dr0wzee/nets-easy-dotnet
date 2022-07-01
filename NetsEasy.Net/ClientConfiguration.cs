using System.Net.Http;

namespace NetEasy
{
    public class ClientConfiguration
    {
        public ClientConfiguration(string secretKey)
        {
            SecretKey = secretKey;
            BaseUrl = Constants.ProductionBaseUrl;
        }

        public string BaseUrl { get; private set; }
        public string SecretKey { get; }
        public HttpClient HttpClient { get; private set; }

        public void SetTestEnvironment()
        {
            BaseUrl = Constants.TestBaseUrl;
        }

        public void SetHttpClient(HttpClient httpClient)
        {
            HttpClient = httpClient;
        }
    }
}