using OOO_SportProduct.Classes;
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
        private void exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void login_Click(object sender, RoutedEventArgs e)
        {
            //Обработка введенных данных
            string login = Login.Text;
            string password = Password.Text;
            StringBuilder strMessage = new StringBuilder();
            if (login == "") strMessage.Append("Введите логин\n\n");
            if (password == "") strMessage.Append("Введите пароль\n\n");

            //Сообщение об ошибке
            if (strMessage.Length > 0)
            {
                MessageBox.Show(strMessage.ToString(), "Ошибка");
                return;
            }

            //Работа с БД, Пользователи

            ////List<DBModel.User> users = new List<DBModel.User>();
            ////users = Helper.DB.Users.ToList();
            ////DBModel.User user = users.FirstOrDefault();
            ////MessageBox.Show(user.UserFullName + " " + user.UserRole.ToString() + " " + user.Role.RoleName);
            ////DBModel.User user = users.Where(u => u.UserLogin == login && u.UserPassword == password).FirstOrDefault();
            
            Helper.User = Helper.DB.Users.ToList().Where(u => u.UserLogin == login && u.UserPassword == password).FirstOrDefault();

            if (Helper.User != null)
            {
                MessageBox.Show(Helper.User.UserFullName + " " + Helper.User.UserRole.ToString() + " " + Helper.User.Role.RoleName);
            }
            else
            {
                MessageBox.Show("Пользователь не найден", "Ошибка");
            }
        }

        private void gost_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
