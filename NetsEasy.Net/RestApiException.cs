using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace NetEasy
{
    public class RestApiException : Exception
    {
        public RestApiException(string message, HttpStatusCode? statusCode, string payload) : base(message)
        {
            StatusCode = statusCode;
            Payload = payload;
        }

        public HttpStatusCode? StatusCode { get; private set; }
        public string Payload { get; private set; }

        public static async Task<RestApiException> FromHttpResponseMessageAsync(HttpResponseMessage httpResponseMessage)
        {
            var message = "No response";
            string content = null;

            if (httpResponseMessage != null)
            {
                
                try
                {
                    using (var reader = new StreamReader(await httpResponseMessage.Content.ReadAsStreamAsync()))
                    {
                        content = await reader.ReadToEndAsync();
                    }
                }
                catch
                {
                    //
                }

                var headers = string.Empty;
                try
                {
                    var builder = new StringBuilder();

                    foreach (var header in httpResponseMessage.Headers)
                    {
                        builder.Append($"{header.Key}:");

                        foreach (var item in header.Value)
                            if (item != null)
                                builder.Append($"{item};");

                        builder.AppendLine();
                    }

                    foreach (var header in httpResponseMessage.Content.Headers)
                    {
                        builder.Append($"{header.Key}:");

                        foreach (var item in header.Value)
                            if (item != null)
                                builder.Append($"{item};");

                        builder.AppendLine();
                    }

                    headers = builder.ToString();
                }
                catch
                {
                    //
                }

                //message = $"StatusCode: {httpResponseMessage.StatusCode} {httpResponseMessage.RequestMessage?.RequestUri?.AbsoluteUri}\n{headers}\n{content}";
                message = $"StatusCode: {httpResponseMessage.StatusCode} ReasonPhrase: {httpResponseMessage.ReasonPhrase}";
            }

            return new RestApiException(message, httpResponseMessage?.StatusCode, content);
        }
    }
}