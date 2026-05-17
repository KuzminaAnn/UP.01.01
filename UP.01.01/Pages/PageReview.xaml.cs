using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace UP._01._01.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageReview.xaml
    /// </summary>
    public partial class PageReview : Page
    {
        List<Book> books;
        public Book book { get; set; }
        public PageReview(Book b)
        {
            book = b;
            InitializeComponent();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PageStart());
            if (NavigationService.CanGoForward)
            {
                NavigationService.GoForward();
            }
        }

        private void Enter_Click(object sender, RoutedEventArgs e)
        {
            if (Text.Text != null && Rating.Text != null)
            {
                float.TryParse(Rating.Text, out float rating);
                Review newReview = new Review
                {
                    IdUser = AffUser.Auser.Id,
                    IdBook = book.Id,
                    Text = Text.Text,
                    Rating = rating
                };
                Core.Context.Review.Add(newReview);
                Core.Context.SaveChanges();
                MessageBox.Show("Отзыв написан");
            }
            else
                MessageBox.Show("Заполните все поля!");
        }
    }
}
