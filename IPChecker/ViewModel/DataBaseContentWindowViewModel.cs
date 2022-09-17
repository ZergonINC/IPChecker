using IPChecker.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace IPChecker.ViewModel
{
    public class DataBaseContentWindowViewModel : BaseViewModel
    {
        IpAddressDataBase ipAddressDataBase = new("Data Source=IPAddressDB.db");

        public DataBaseContentWindowViewModel()
        {
            // загружаем данные из БД
            ipAddressDataBase.IpAddress.Load();
            // и устанавливаем данные в качестве контекста
            ipAddressDataBase.IpAddress.Local.ToObservableCollection();//
        }

        // Удаление.
        public ICommand DeleteCommand
        {
            get
            {
                return new RelayCommand((parameter) =>
                {
                    // получаем выделенный объект
                    DataByIPAddress user = usersList.SelectedItem as User;
                    // если ни одного объекта не выделено, выходим
                    if (user is null) return;
                    ipAddressDataBase.IpAddress.Remove(user);

                    ipAddressDataBase.SaveChanges();
                });
            }
        }

        // добавление
        public ICommand UseCommand
        {
            get
            {
                return new RelayCommand((parameter) =>
                {
                    // получаем выделенный объект
                    User? user = usersList.SelectedItem as User;
                    // если ни одного объекта не выделено, выходим
                    if (user is null) return;



                });
            }
        }
    }
}
