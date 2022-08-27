using IPChecker.Interfaces;
using IPChecker.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPChecker.Model
{
    internal class IPCheckerModel : BaseViewModel, IBaseModel
    {
        private string _ip;

        public string IP
        {
            get { return _ip; }

            set
            {
                _ip = value;
                RaisePropertyChanged(nameof(_ip));
            }
        }

        private string _myIP;

        public string MyIP
        {
            get { return _myIP; }

            set
            {
                _myIP = value;
                RaisePropertyChanged(nameof(_myIP));
            }
        }

        private string _country;

        public string Country
        {
            get { return _country; }

            set
            {
                _country = value;
                RaisePropertyChanged(nameof(_country));
            }
        }

        private string _region;

        public string Region
        {
            get { return _region; }

            set
            {
                _region = value;
                RaisePropertyChanged(nameof(_region));
            }
        }

        private string _city;

        public string City
        {
            get { return _city; }

            set
            {
                _city = value;
                RaisePropertyChanged(nameof(_city));
            }
        }

        private string _currency;

        public string Currency
        {
            get { return _currency; }

            set
            {
                _currency = value;
                RaisePropertyChanged(nameof(_currency));
            }
        }
    }
}
