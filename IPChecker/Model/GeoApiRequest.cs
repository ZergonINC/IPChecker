using System.Net.Http;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
using System.Threading.Tasks;

namespace IPChecker.Model
{
    internal class GeoApiRequest
    {
        // Возможно нужен запрос для провайдера https://api.2ip.ua/provider.json?ip={ip}

        internal async Task<DataByIPAddress> SendRequest(string geoApiXml)
        {
            // Устанавливаем опции десериализации(чтение кириллицы и игнорирование регистра свойств).

            JsonSerializerOptions serializerOptions = new()
            {
                Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
                
                WriteIndented = true,

                PropertyNameCaseInsensitive = true
            };

            // Получаем Api ответ от 2ip.ua.

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(geoApiXml))
            {
                // Проверяем успешность операции

                if (response.IsSuccessStatusCode)
                {
                    // Десериализуем Api Json в специальный класс JsonValues для дальнейшего взаимодействия.

                    DataByIPAddress data = JsonSerializer.Deserialize<DataByIPAddress>(await response.Content.ReadAsStringAsync(), serializerOptions);

                    return data;
                }
                else
                {
                    // В случае провала проверки возвращаем пустой класс.

                    DataByIPAddress emptyData = new();

                    return emptyData;
                }
            }
        }
    }
}

