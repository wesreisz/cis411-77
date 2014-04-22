using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
namespace GeoCodeTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            GeoResult geoResult = GeoUtil.getResultFromAddress("1600 Amphitheatre Parkway, Mountain View, CA 94043");
            Assert.AreEqual("1600 Amphitheatre Parkway, Mountain View, CA 94043, USA", geoResult.results[0].formatted_address);
            Assert.AreEqual(37.422, geoResult.results[0].geometry.location.lat,.1);
        }
    }
}
