using Map.Library.ApiHelper;
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
        [Test]
        public void Should_return_httpClient()
        {
            ApiHelper.ApiHelper.InitializeClient();
            ApiHelper.ApiHelper.Client.ShouldBeOfType(typeof(HttpClient));
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