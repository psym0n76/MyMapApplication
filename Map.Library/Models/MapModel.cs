using System;
using System.Linq;

namespace Map.Library.Models
{
    public class MapModel
    {
        public string Location { get; set; }
        public Result[] Results { get; set; }
        public Status Status { get; set; }

        public override string ToString()
        {
            var longitude = Results.Select(x => x.Geometry.Lat).FirstOrDefault();
            var latitude = Results.Select(x => x.Geometry.Lat).FirstOrDefault();

            return $"Date: {DateTime.Now} Searched Item: {Location} Lat: {latitude} Long: {longitude} Status: {Status.Code} StatusMessage:{Status.Message}";
        }
    }
}