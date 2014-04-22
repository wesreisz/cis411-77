using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestGeoLocationJson()
        {
            GeoResult result = GeoUtil.geoMapAddress("500 South Preston Street, Louisville, KY 40202");
            Assert.AreEqual(38.2494049072266, result.results[0].geometry.location.lat,0.1);
            Assert.AreEqual(-85.74692109999999, result.results[0].geometry.location.lng,0.1);
            Assert.AreEqual("500 South Preston Street, Louisville, KY 40202, USA", result.results[0].formatted_address);
        }
    }
}
