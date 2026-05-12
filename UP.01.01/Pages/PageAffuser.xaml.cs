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

namespace UP._01._01.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageAffuser.xaml
    /// </summary>
    public partial class PageAffuser : Page
    {
        List<User> users = Core.Context.User.ToList();
        public PageAffuser()
        {
            InitializeComponent();

        }

        private void Aff_Click(object sender, RoutedEventArgs e)
        {
            User afuser = users.First(U => U.Login.ToLower() == login.Text.ToLower());

            string password = Password.Password;
            if (afuser.Password == password)
            {
                AffUser.Auser = afuser;
                MessageBox.Show("Вы вошли в свой аккаунт!");
                NavigationService.Navigate(new PageProf());
                if (NavigationService.CanGoForward)
                {
                    NavigationService.GoForward();
                }
            }
            else
            {
                MessageBox.Show("Неверный пароль");
            }
        }

        private void Registr_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PageReg());
            if (NavigationService.CanGoForward)
            {
                NavigationService.GoForward();
            }
        }
    }
}
