using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

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
