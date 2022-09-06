using IPChecker.Model;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Controls;
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


        GeoApiRequest geoApiRequest = new();

        public ICommand CheckIPCommand
        {
            get
            {
                return new RelayCommand(async (parameter) =>
                {
                    var b = await geoApiRequest?.SendRequest(IPField);

                }, (parameter) => true);//Добавить условие
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
