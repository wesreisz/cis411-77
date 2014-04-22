using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Xml;

class FuelEconomyUtil
{
    private const String BASE_URL = "http://www.fueleconomy.gov/ws/rest/vehicle/";

    public static DataSet getCarEconmy(string carId)
    {
        DataSet ds = new DataSet();

        String url = BASE_URL + carId;
        using (var w = new WebClient())
        {
            var xml_data = string.Empty;
            try
            {
                xml_data = w.DownloadString(url);
                ds.ReadXml(new XmlTextReader(new StringReader(xml_data)));
            }
            catch (Exception)
            {
                Console.Out.WriteLine("Failed to download url: " + url);
            }
        }
        return ds;
    }
}
