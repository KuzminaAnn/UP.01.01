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
using static System.Collections.Specialized.BitVector32;

namespace UP._01._01.Pages
{
    /// <summary>
    /// Логика взаимодействия для PagePodrob.xaml
    /// </summary>
    public partial class PagePodrob : Page
    {
        List<Book> books;
        List<Review> reviews = Core.Context.Review.ToList();

        public Book book { get; set; }
        public BookGener genreb { get; set; }
        public Review review { get; set; }
        public PagePodrob(Book b)
        {
            InitializeComponent();
            book = b;
            this.DataContext = this;
            foreach (var a in book.BookGener)
                ganre.Text = a.Gener.Name;
            books = Core.Context.Book.Where(g => g.Id == book.Id).ToList();
            NameBook.Text = book.Name;
            BookBox.ItemsSource = books;
            reviews = Core.Context.Review.Where(g => g.IdBook == book.Id).ToList();
            Revie.ItemsSource = reviews;
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PageStart());
            if (NavigationService.CanGoForward)
            {
                NavigationService.GoForward();
            }
        }
        private void Load()
        {
            BookBox.ItemsSource = null;
            
        }

        private void Read_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PageText());
            if (NavigationService.CanGoForward)
            {
                NavigationService.GoForward();
            }
        }
    }
}
