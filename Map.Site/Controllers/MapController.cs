using Map.Library;
using Map.Site.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Map.Site.Controllers
{
    public class MapController : Controller
    {
        private readonly IMapReader _mapReader;

        public MapController(IMapReader mapReader)
        {
            _mapReader = mapReader;
        }

        public IActionResult Index()
        {
            var result = new MapViewModel();
            return View(result);
        }

        public ActionResult GetLocation(MapViewModel map)
        {
            if (!ModelState.IsValid)
            {
                return View("Index", map);
            }

            var result = _mapReader.GetGeoLocation(map.Location);

            map.Latitude = result.Results.Select(x => x.Geometry.Lat).FirstOrDefault();
            map.Longitude = result.Results.Select(x => x.Geometry.Lng).FirstOrDefault();

            return View("Index", map);
        }
    }
}