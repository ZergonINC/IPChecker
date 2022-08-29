using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace IPChecker.Model
{
    internal class HttpResponse
    {
        internal async Task<string> GetResponse(string line)
        {
            using (HttpClient net = new())
            {
                var response = await net.GetAsync(line);

                return response.IsSuccessStatusCode ? await response.Content.ReadAsStringAsync() : null;
            }

            string geoApiXml = "";
            using (HttpClient client = new())
                geoApiXml = await httpResponse.GetResponse($"http://ipwhois.app/xml/{ip}");  // https://api.2ip.ua/provider.xml?ip={ip}
        }
    }
}
