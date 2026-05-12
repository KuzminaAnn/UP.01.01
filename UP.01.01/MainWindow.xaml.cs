using System.Windows;
using System.Windows.Navigation;
using UP._01._01.Pages;

namespace UP._01._01
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            if (AffUser.Auser.IdRole == 1)
            {
                Admin.Visibility = Visibility.Visible;
            }
        }

        private void MainBook_Click(object sender, RoutedEventArgs e)
        {
            navframe.Navigate(new PageStart());
            if (navframe.CanGoForward)
            {
                navframe.GoForward();
            }
        }

        private void BookSpesk_Click(object sender, RoutedEventArgs e)
        {
            if (AffUser.Auser == null)
            {
                navframe.Navigate(new PageNoSpisk());
                if (navframe.CanGoForward)
                {
                    navframe.GoForward();
                }
            }
            else
            {
                navframe.Navigate(new PageSpesk());
                if (navframe.CanGoForward)
                {
                    navframe.GoForward();
                }
            }
        }

        private void UserProf_Click(object sender, RoutedEventArgs e)
        {
            if (AffUser.Auser == null)
            {
                navframe.Navigate(new PageAffuser());
                if (navframe.CanGoForward)
                {
                    navframe.GoForward();
                }
            }
            else
            {
                navframe.Navigate(new PageProf());
                if (navframe.CanGoForward)
                {
                    navframe.GoForward();
                }
            }

        }

        private void Admin_Click(object sender, RoutedEventArgs e)
        {
            navframe.Navigate(new PageAdmin());
            if (navframe.CanGoForward)
            {
                navframe.GoForward();
            }
        }
    }
}
