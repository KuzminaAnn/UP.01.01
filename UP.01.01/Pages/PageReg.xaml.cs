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
    /// Логика взаимодействия для PageReg.xaml
    /// </summary>
    public partial class PageReg : Page
    {
        public PageReg()
        {
            InitializeComponent();
           
        }

        private void Regist_Click(object sender, RoutedEventArgs e)
        {
            User newUser = new User
            {
                Name = Name.Text,
                Login = Login.Text,
                Password = Password.Text,
                Email = Email.Text,
                IdRole = 3,
                Freez = false
            };
            Core.Context.User.Add(newUser);
            Core.Context.SaveChanges();
            User reguser = newUser;
            AffUser.Auser = reguser;
            MessageBox.Show("Вы зарегистрировались!");
            NavigationService.Navigate(new PageProf());
            if (NavigationService.CanGoForward)
            {
                NavigationService.GoForward();
            }
        }
    }
}
