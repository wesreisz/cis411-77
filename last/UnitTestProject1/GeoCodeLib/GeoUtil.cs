using System;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Web;

namespace GeoCodeTest
{
    public class GeoUtil
    {
        private const String BASE_URL = "https://maps.googleapis.com/maps/api/geocode/json?sensor=true&address=";

        public static GeoResult getResultFromAddress(string address) {
            using (var w = new WebClient())
            {
                var json_data = string.Empty;
                var url = string.Empty;
                try
                {
                    url = BASE_URL + HttpUtility.UrlEncode(address);
                    json_data = w.DownloadString(url);
                }
                catch (Exception e)
                {
                    Console.Out.WriteLine("Failed to download url: " + url);
                    return new GeoResult();
                }
                return JsonConvert.DeserializeObject<GeoResult>(json_data);
            }
        }
    }
}
