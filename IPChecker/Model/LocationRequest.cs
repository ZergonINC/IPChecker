using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace IPChecker.Model
{
    internal class LocationRequest
    {
        internal void GetLocation()
        {
            Match location = Regex.Match(geoApiXml, "<latitude>(.*?)</latitude>(.*?)<longitude>(.*?)</longitude>");

            string latitude = location.Groups[1].Value;

            string longitude = location.Groups[3].Value;

            var url = new Uri($"https://www.google.com/maps/search/?api=1&query={latitude},{longitude}");
        }
    }
}
