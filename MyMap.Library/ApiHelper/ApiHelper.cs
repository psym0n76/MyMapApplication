using System.Net.Http;
using System.Net.Http.Headers;

namespace Map.Library
{
    public static class ApiHelper
    {
        //create a static property to hold the http client (single state)
        public static HttpClient Client { get; set; }

        public static void InitializeClient()
        {
            Client = new HttpClient();
            Client.DefaultRequestHeaders.Accept.Clear();
            Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}