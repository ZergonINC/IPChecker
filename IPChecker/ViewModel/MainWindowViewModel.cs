using System.Windows.Input;

namespace IPChecker.ViewModel
{
    internal class MainWindowViewModel : BaseViewModel
    {
        private string _ipField;
        public string IPField
        {
            get { return _ipField; }

            set
            {
                _ipField = value;
                RaisePropertyChanged(nameof(_ipField));
            }
        }

        private string _countryField;
        public string CountryField
        {
            get { return _countryField; }

            set
            {
                _ipField = value;
                RaisePropertyChanged(nameof(_countryField));
            }
        }

        private string _regionField;
        public string RegionField
        {
            get { return _regionField; }

            set
            {
                _ipField = value;
                RaisePropertyChanged(nameof(_regionField));
            }
        }

        private string _cityField;
        public string CityField
        {
            get { return _cityField; }

            set
            {
                _ipField = value;
                RaisePropertyChanged(nameof(_cityField));
            }
        }

        private string _currencyField;
        public string CurrencyField
        {
            get { return _currencyField; }

            set
            {
                _ipField = value;
                RaisePropertyChanged(nameof(_currencyField));
            }
        }

        private string _currentIPField;
        public string CurrentIPField
        {
            get { return _currentIPField; }

            set
            {
                _ipField = value;
                RaisePropertyChanged(nameof(_currentIPField));
            }
        }

        public ICommand CheckIPCommand
        {
            get
            {
                return new RelayCommand((parameter) =>
                {

                });
            }
        }

        public ICommand GetMyIPCommand
        {
            get
            {
                return new RelayCommand((parameter) =>
                {

                });
            }
        }
    }
}
