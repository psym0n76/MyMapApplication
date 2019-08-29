using System.Threading.Tasks;

namespace Map.Library.ApiHelper
{
    public interface IApiProcessor
    {
        Task<T> LoadAsync<T>(string url);
        Task<T> LoadAsStringAsync<T>(string url);
    }
}