using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace OOO_SportProduct
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //Подключение к БД
            Classes.Helper.DB = new DBModel.DataSpaceSportProduct();
        }

        private void login_Click(object sender, RoutedEventArgs e)
        {

        }

        private void gost_Click(object sender, RoutedEventArgs e)
        {

        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
