using System.Collections.Generic;
using System.Linq;
using System.Windows.Controls;

namespace UP._01._01.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageProf.xaml
    /// </summary>
    public partial class PageProf : Page
    {
        List<User> users;
        List<Review> reviews = Core.Context.Review.ToList();
        public User user { get; set; }
        public Review review { get; set; }
        public PageProf()
        {
            InitializeComponent();
        }

        private void Load()
        {
            if (AffUser.Auser != null)
            {
                NameUser.Text = AffUser.Auser.Name;
                Login.Text = AffUser.Auser.Login;
                Email.Text = AffUser.Auser.Email;
                Role.Text = AffUser.Auser.Role.Name;
                reviews = Core.Context.Review.Where(g => g.IdUser == AffUser.Auser.Id).ToList();
                UserRev.ItemsSource = reviews;

                if (AffUser.Auser.Freez == true)
                {
                    Fr.Visibility = System.Windows.Visibility.Visible;
                    Autor.Visibility = System.Windows.Visibility.Collapsed;
                }
                if (AffUser.Auser.IdRole == 2 | AffUser.Auser.IdRole == 1)
                    Autor.Visibility = System.Windows.Visibility.Collapsed;
            }

        }

        private void Page_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            Load();
        }

        private void Autor_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            NavigationService.Navigate(new PageFreez());
            if (NavigationService.CanGoForward)
            {
                NavigationService.GoForward();
            }
        }
    }
}
