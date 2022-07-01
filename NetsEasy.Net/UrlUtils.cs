namespace NetEasy
{
    internal static class UrlUtils
    {
        public static string SimpleCombineUrl(this string uri1, string uri2)
        {
            return $"{uri1.TrimEnd('/')}/{uri2.TrimStart('/')}";
        }
    }
}