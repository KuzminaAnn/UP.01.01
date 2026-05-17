using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

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
            if (Status.Text != null)
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
            else
                MessageBox.Show("Заполните поле!");

        }

    }
}
