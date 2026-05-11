using System.Windows;

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
            navframe.Visibility = Visibility.Visible;
            navframe1.Visibility = Visibility.Hidden;
            navframe2.Visibility = Visibility.Hidden;
            navframe3.Visibility = Visibility.Hidden;
        }

        private void BookSpesk_Click(object sender, RoutedEventArgs e)
        {
            navframe1.Visibility = Visibility.Visible;
            navframe.Visibility = Visibility.Hidden;
            navframe2.Visibility = Visibility.Hidden;
            navframe3.Visibility = Visibility.Hidden;
        }

        private void UserProf_Click(object sender, RoutedEventArgs e)
        {
            if (AffUser.Auser == null)
            {
                navframe3.Visibility = Visibility.Visible;
                navframe2.Visibility = Visibility.Hidden;
                navframe.Visibility = Visibility.Hidden;
                navframe1.Visibility = Visibility.Hidden;
            }
            else
            {
                navframe2.Visibility = Visibility.Visible;
                navframe.Visibility = Visibility.Hidden;
                navframe1.Visibility = Visibility.Hidden;
                navframe3.Visibility = Visibility.Hidden;
            }

        }
    }
}
