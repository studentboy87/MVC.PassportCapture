using System;
using System.Threading;
using APIClient;
using Web.PassportCapture.Utility;


namespace Web.PassportCapture.Factory
{
    internal static class ApiClientFactory
    {
        private static Uri apiUri;

        private static Lazy<ApiClient> restClient = new Lazy<ApiClient>(
            () => new ApiClient(apiUri),
            LazyThreadSafetyMode.ExecutionAndPublication);

        static ApiClientFactory()
        {
            apiUri = new Uri(ApiAuth.WebApiUrl);
        }

        public static ApiClient Instance => restClient.Value;
    }
}
