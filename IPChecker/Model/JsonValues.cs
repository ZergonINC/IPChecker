using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPChecker.Model
{
    internal class JsonValues
    {
        private string _country;

        public string Country 
        { 
            get { return _country; }
            
            set { _country = value; }
        }

        private string _region;

        public string Region            
        { 
            get { return _region; } 

            set { _region = value; } 
        }

        private string _city;

        public string City
        {
            get { return _city; }

            set { _city = value; }
        }

        private string _currency;

        public string Currency
        {
            get { return _currency; }

            set { _currency = value; }
        }

        private string _latitude;

        public string Latitude
        {
            get { return _latitude; }

            set { _latitude = value; }
        }

        private string _longitude;

        public string Longitude
        {
            get { return _longitude; }

            set { _longitude = value; }
        }
    }
}
