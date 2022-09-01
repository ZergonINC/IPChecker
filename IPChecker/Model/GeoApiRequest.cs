using System.Net.Http;
using System.Text.Json;

namespace IPChecker.Model
{
    internal class GeoApiRequest
    {
        async void SendRequest(string ip)
        {
            string geoApiXml = $"http://ipwhois.app/xml/{ip}"; // https://api.2ip.ua/provider.xml?ip={ip}

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(geoApiXml))
            {
                if (response.IsSuccessStatusCode)
                {
                    JsonValues jsonValues = JsonSerializer.Deserialize<JsonValues>(await response.Content.ReadAsStringAsync());

                }
            }
        }
    }
}

