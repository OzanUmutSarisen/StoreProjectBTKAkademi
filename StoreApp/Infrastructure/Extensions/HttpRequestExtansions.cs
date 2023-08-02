namespace StoreApp.Infrastructure.Extensions
{
    public static class HttpRequestExtansions
    {
        public static string PathAndQuery(this HttpRequest request)
        {
            return request.QueryString.HasValue
                ? $"{request.Path}{request.QueryString}"
                : request.Path.ToString();
        }

    }
}