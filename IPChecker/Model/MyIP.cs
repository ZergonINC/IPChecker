using System;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace IPChecker.Model
{
    internal class MyIP
    {
        async void GetMyIP(string myIP)
        {
            await Task.Run(() =>
            {
                var line = "";
                using (WebClient wc = new WebClient())
                    line = wc.DownloadString($"http://ipwhois.app/xml/{textBox1.Text}");
                Action action = () =>
                {
                    Match data = Regex.Match(line, "<country>(.*?)</country>(.*?)<region>(.*?)</region>(.*?)<city>(.*?)</city>(.*?)<currency>(.*?)</currency>");
                    Match location = Regex.Match(line, "<latitude>(.*?)</latitude>(.*?)<longitude>(.*?)</longitude>");
                    Country.Text = data.Groups[1].Value;
                    Region.Text = data.Groups[3].Value;
                    City.Text = data.Groups[5].Value;
                    Currency.Text = data.Groups[7].Value;
                    string latitude = location.Groups[1].Value;
                    string longitude = location.Groups[3].Value;
                    webBrowser1.Url = new Uri($"https://www.google.com/maps/search/?api=1&query={latitude},{longitude}");
                    webBrowser1.ScriptErrorsSuppressed = true;
                };
                if (InvokeRequired)
                    Invoke(action);
                else
                    action();
            });
        }
    }
}
