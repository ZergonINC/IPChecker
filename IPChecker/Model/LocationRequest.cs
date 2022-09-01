using System;
using System.Text.RegularExpressions;

namespace IPChecker.Model
{
    internal class LocationRequest
    {
        internal void GetLocation()
        {

            var url = new Uri($"https://www.google.com/maps/search/?api=1&query={latitude},{longitude}");
        }
    }
}
