using System.Windows;
using UP._01._01.Pages;

namespace UP._01._01
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        User _upUser;
        public MainWindow()
        {
            InitializeComponent();
            Admin.Visibility = Visibility.Collapsed;
            Autor.Visibility = Visibility.Collapsed;

            //Load();
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

        private void Autor_Click(object sender, RoutedEventArgs e)
        {
            navframe.Navigate(new PageAtour());
            if (navframe.CanGoForward)
            {
                navframe.GoForward();
            }
        }

        private void Freez_Click(object sender, RoutedEventArgs e)
        {
            navframe.Navigate(new PageFreez());
            if (navframe.CanGoForward)
            {
                navframe.GoForward();
            }
        }

        private void Load()
        {


        }

        private void navframe_Navigated(object sender, System.Windows.Navigation.NavigationEventArgs e)
        {
            
            if(_upUser == AffUser.Auser) return;
            if (AffUser.Auser == null) return;
            
            _upUser = AffUser.Auser;
            
            if(_upUser.Freez == true) ;//

            switch (AffUser.Auser.IdRole)
            {
                case 1:
                    Admin.Visibility = Visibility.Visible;
                    break;

                case 2:
                    Autor.Visibility = Visibility.Visible;
                    break;
            }

            
        }
    }
}
