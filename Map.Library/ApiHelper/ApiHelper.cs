using System.Net.Http;
using System.Net.Http.Headers;

namespace Map.Library.ApiHelper
{
    public static class ApiHelper
    {
        public static HttpClient Client { get; set; }

        public static void InitializeClient()
        {
            Client = new HttpClient();
            Client.DefaultRequestHeaders.Accept.Clear();
            Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}