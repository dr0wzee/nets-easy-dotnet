using System;
using System.Net.Http;

namespace NetEasy
{
    internal static class DefaultHttpClient
    {
        private static readonly Lazy<HttpClient> _instance = new Lazy<HttpClient>(() => new HttpClient());
        public static HttpClient Instance => _instance.Value;
    }
}