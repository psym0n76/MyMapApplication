using Map.Library.Models;

namespace Map.Library
{
    public interface IMapReader
    {
        MapModel GetGeoLocation(string location);
    }
}