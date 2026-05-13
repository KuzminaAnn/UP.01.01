using System.Windows;
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
            //Admin.Visibility = Visibility.Collapsed; 
            //Autor.Visibility = Visibility.Collapsed;
            //if (AffUser.Auser != null)
            //{

                
            //    switch (AffUser.Auser.IdRole)
            //    {
            //        case 1:
            //            Admin.Visibility = Visibility.Visible;
            //            break;

            //        case 2:
            //            Autor.Visibility = Visibility.Visible;
            //            break;
            //    }
                //        if (AffUser.Auser.IdRole == 1)
                //{
                //    Admin.Visibility = Visibility.Visible;
                //}
                //if (AffUser.Auser.IdRole == 2)
                //{
                //    Autor.Visibility = Visibility.Visible;
                //}
                //if (AffUser.Auser.Freez == true)
                //{
                //    Freez.Visibility = Visibility.Visible;
                //}
            //}

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
    }
}
