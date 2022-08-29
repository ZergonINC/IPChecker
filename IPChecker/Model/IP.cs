using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace IPChecker.Model
{
    internal class IP
    {
        private HttpResponse httpResponse = new();

        async void GetIP(string ip)
        {


            await Task.Run(() =>
            {
                Action action = () =>
                {
                    Match data = Regex.Match(geoApiXml, "<country>(.*?)</country>(.*?)<region>(.*?)</region>(.*?)<city>(.*?)</city>");

                    var Country = data.Groups[1].Value;
                    var Region = data.Groups[3].Value;
                    var City = data.Groups[5].Value;
                    
                };
                //if (InvokeRequired)
                //    Invoke(action);
                //else
                //    action();
            });
        }

    }
}

