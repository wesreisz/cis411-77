using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Net;
using System.Data;
using System.IO;
using System.Xml;

namespace FuelEconomyTest
{
    [TestClass]
    public class UnitTest1
    {
       
        [TestMethod]
        public void TestFuelEconmyFromXml()
        {
            String carId = "31873";
            DataSet carData = FuelEconomyUtil.getCarEconmy(carId);
            String co2TailpipeAGpm = (String)carData.Tables[0].Rows[0]["co2TailpipeAGpm"];
            String co2TailpipeGpm = (String)carData.Tables[0].Rows[0]["co2TailpipeGpm"];
            Assert.AreEqual("629.5", co2TailpipeAGpm);
            Assert.AreEqual("592.4666666666667", co2TailpipeGpm);
        }
    }
}
