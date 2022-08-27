using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
