using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;

/**
 * Class accepts a single url and returns a dot net object from 
 * google with the geocoded information
 **/
public class GeoUtil
{
    //google api for geocoding an address
    private const String BASE_URL = "https://maps.googleapis.com/maps/api/geocode/json?sensor=true&address=";

    public static GeoResult geoMapAddress(string address) {
        var url = BASE_URL + HttpUtility.UrlEncode(address);
        using (var w = new WebClient())
        {
            var json_data = string.Empty;
            try
            {
                json_data = w.DownloadString(url);
            }
            catch (Exception) {
                Console.Out.WriteLine("Failed to download url: " + url);
                return new GeoResult();
            }

            // install-package Newtonsoft.Json
            // paste json to class
            return JsonConvert.DeserializeObject<GeoResult>(json_data);
        }
    }        
}