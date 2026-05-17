using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace UP._01._01.Pages
{
    /// <summary>
    /// Логика взаимодействия для PagePodrob.xaml
    /// </summary>
    public partial class PagePodrob : Page
    {
        List<Review> reviews ;

        public Book book { get; set; }
        public BookGener genreb { get; set; }
        public Review review { get; set; }
        public PagePodrob(Book b)
        {
            InitializeComponent();
            book = b;
            this.DataContext = this;
            reviews = Core.Context.Review.Where(g => g.IdBook == book.Id).ToList();
            Revie.ItemsSource = reviews;

            if (AffUser.Auser != null)
            {
                if (AffUser.Auser.IdRole == 1)
                {
                    Freez.Visibility = Visibility.Visible;
                }
                if (AffUser.Auser.Freez == true)
                {
                    Revies.Visibility = Visibility.Collapsed;
                    Ban.Visibility = Visibility.Collapsed;
                }
            }
            else if (AffUser.Auser == null)
            {
                Revies.Visibility = Visibility.Collapsed;
                Ban.Visibility = Visibility.Collapsed;

            }
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PageStart());
            if (NavigationService.CanGoForward)
            {
                NavigationService.GoForward();
            }
        }

        private void Read_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PageText());
            if (NavigationService.CanGoForward)
            {
                NavigationService.GoForward();
            }
        }

        private void Ban_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PageBan(book));
            if (NavigationService.CanGoForward)
            {
                NavigationService.GoForward();
            }
        }

        private void Revies_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PageReview(book));
            if (NavigationService.CanGoForward)
            {
                NavigationService.GoForward();
            }
        }

        private void Freez_Click(object sender, RoutedEventArgs e)
        {
            book.Freez = true;
        }
    }
}
