using Map.Library.Logger;
using Map.Library.Models;
using NUnit.Framework;
using Shouldly;
using System.Net.Http;

namespace Map.Library.Tests
{
    [TestFixture]
    public class MapReaderTests
    {

        public const string url = "https://api.opencagedata.com/geocode/v1/json?q=51.47814%2C%20-0.09888&key=83d4e64ab9a346b790ecdbad4c6c09d6&language=en&pretty=1";

        [Test]
        public void Should_return_httpClient()
        {

            ApiHelper.InitializeClient();
            ApiHelper.Client.ShouldBeOfType(typeof(HttpClient));
        }


        [Test]
        public void Should_return_map_object_from_api()
        {
            var response = new MapReader(new ApiProcessor(), new LogWriter());
            var result = response.GetGeoLocation("London");

            result.ShouldBeAssignableTo(typeof(MapModel));
        }


        [Test]
        public void Should_return_ok_response_from_api()
        {
            var response = new MapReader(new ApiProcessor(), new LogWriter());
            var result = response.GetGeoLocation("London");
            result.Status.Code.ShouldBe("200");
        }
    }
}