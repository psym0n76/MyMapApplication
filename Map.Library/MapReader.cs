using Map.Library.Logger;
using Map.Library.Models;
using System.Threading.Tasks;
using Map.Library.ApiHelper;


namespace Map.Library
{
    public class MapReader : IMapReader
    {
        private readonly IApiProcessor _apiProcessor;
        private readonly ILogWriter _logWriter;

        public MapReader(IApiProcessor apiProcessor, ILogWriter logWriter)
        {
            _apiProcessor = apiProcessor;
            _logWriter = logWriter;
        }

        public MapModel GetGeoLocation(string location)
        {
            ApiHelper.ApiHelper.InitializeClient();

            var url = "https://api.opencagedata.com/geocode/v1/json?q=" + location + "&key=83d4e64ab9a346b790ecdbad4c6c09d6&language=en&pretty=1";

            var task = _apiProcessor.LoadAsStringAsync<MapModel>(url);

            Task.WaitAll(task);

            var result = task.Result;

            result.Location = location;

            _logWriter.WriteMessage(result.ToString());

            return result;
        }
    }
}