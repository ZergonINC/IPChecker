using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPChecker.Model
{
    internal class Class1
    {
        GeoApiRequest geoApiRequest = new();

        LocationRequest locationRequest = new();

        async Task<Uri> Metod(string ip)
        {
            string geoApi = $"https://api.2ip.ua/geo.json?ip={ip}";

            DataByIPAddress data = await geoApiRequest.SendRequest(geoApi);

            return locationRequest.GetLocationUri(data?.Latitude, data?.Longitude);
        }
    }
}
