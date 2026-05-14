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
using static System.Net.Mime.MediaTypeNames;

namespace UP._01._01.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageFreez.xaml
    /// </summary>
    public partial class PageFreez : Page
    {
        public PageFreez()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PageProf());
            if (NavigationService.CanGoForward)
            {
                NavigationService.GoForward();
            }
        }

        private void Enter_Click(object sender, RoutedEventArgs e)
        {
            Applications newApplications = new Applications
            {
                IdUser = AffUser.Auser.Id,
                Status = Status.Text
            };
            Core.Context.Applications.Add(newApplications);
            Core.Context.SaveChanges();
            MessageBox.Show("Заявка отправлена");

            NavigationService.Navigate(new PageProf());
            if (NavigationService.CanGoForward)
            {
                NavigationService.GoForward();
            }
        }

    }
}
