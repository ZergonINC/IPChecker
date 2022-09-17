using IPChecker.Model;
using System.Windows;

namespace IPChecker.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // При запуске инициализирум объект ApiHelper.

            ApiHelper.InitializeClient();
        }
    }
}
