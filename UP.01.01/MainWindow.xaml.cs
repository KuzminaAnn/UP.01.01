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
            navframe.Navigate(new PageSpesk());
            if (navframe.CanGoForward)
            {
                navframe.GoForward();
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
    }
}
