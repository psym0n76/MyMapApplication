using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Map.Library.ApiHelper
{
    public class ApiProcessor : IApiProcessor
    {
        public async Task<T> LoadAsync<T>(string url)
        {
            using (var response = await ApiHelper.Client.GetAsync(url))
            {
                if (!response.IsSuccessStatusCode) throw new Exception(response.ReasonPhrase);

                var result = await response.Content.ReadAsAsync<T>();

                return result;
            }
        }

        public async Task<T> LoadAsStringAsync<T>(string url)
        {
            using (var response = await ApiHelper.Client.GetAsync(url))
            {
                if (!response.IsSuccessStatusCode) throw new Exception(response.ReasonPhrase);

                var result = await response.Content.ReadAsStringAsync();

                var d = JsonConvert.DeserializeObject<T>(result);

                return d;
            }
        }
    }
}