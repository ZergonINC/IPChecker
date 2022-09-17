using System;
using System.Security.Policy;
using System.Text.RegularExpressions;

namespace IPChecker.Model
{
    internal class LocationRequest
    {
        internal Uri GetLocationUri(string latitude, string longitude)
        {
            // Получаем широту и долготу, и с ее помощью формируем Api запрос к Google Maps.

            Uri locationUri = new($"https://www.google.com/maps/search/?api=1&query={latitude},{longitude}");//UriKind.RelativeOrAbsolute

            return locationUri;
        }
    }
}
