using System.Net;

namespace IPChecker.Model
{
    internal class Internet
    {
        bool OK()
        {
            try
            {
                Dns.GetHostEntry("grant.ns.cloudflare.com");
                return true;
            }
            catch
            {
                return false;
            }



        }
    }
}
