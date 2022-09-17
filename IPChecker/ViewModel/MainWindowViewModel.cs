using IPChecker.Model;
using System;
using System.Globalization;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace IPChecker.ViewModel
{
    public class MainWindowViewModel : BaseViewModel
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

        private Uri _location;
        public Uri Location
        {
            get { return _location; }

            set
            {
                _location = value;
                RaisePropertyChanged(nameof(_location));
            }
        }

       

        IpAddressDataBase ipAddressDataBase = new("Data Source=IPAddressDB.db");

        public MainWindowViewModel()
        {
            
        }

        public ICommand CheckIPCommand
        {
            get
            {
                return new RelayCommand(async (parameter) =>
                {
                    

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

        // добавление
        public ICommand OpenDBCommand
        {
            get
            {
                return new RelayCommand((parameter) =>
                {
                    //Добавить проверку на null
                    ipAddressDataBase.Add(IpAddress);//добавляем текущий объект
                    ipAddressDataBase.SaveChanges();
                });
            }
        }
    }
}
