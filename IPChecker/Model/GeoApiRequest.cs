using System.Net.Http;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
using System.Threading.Tasks;

namespace IPChecker.Model
{
    internal class GeoApiRequest
    {
        //Возможно нужен запрос для провайдера https://api.2ip.ua/provider.json?ip={ip}

        internal async Task<JsonValues> SendRequest(string ip)
        {
            string geoApiXml = $"https://api.2ip.ua/geo.json?ip={ip}";

            JsonSerializerOptions serializerOptions = new()
            {
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
                
                WriteIndented = true,

                PropertyNameCaseInsensitive = true
            };

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(geoApiXml))
            {
                if (response.IsSuccessStatusCode)
                {
                    JsonValues jsonValues = JsonSerializer.Deserialize<JsonValues>(await response.Content.ReadAsStringAsync(), serializerOptions);

                    return jsonValues;
                }
                else
                {
                    JsonValues emptyJsonValues = new();

                    return emptyJsonValues;
                }
            }
        }
    }
}

