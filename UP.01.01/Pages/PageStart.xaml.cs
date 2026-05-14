using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Navigation;

namespace UP._01._01.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageStart.xaml
    /// </summary>
    public partial class PageStart : Page
    {
        List<Book> book = Core.Context.Book.ToList();
        List<Gener> gener = Core.Context.Gener.ToList();
        public Book books { get; set; }
        public PageStart()
        {

            InitializeComponent();
            Load();

            List<Sortir> ssort = new List<Sortir>()
            {
                new Sortir
                {
                    Name = "По названию",
                },
                new Sortir
                {
                    Name = "По рейтингу",
                },
                new Sortir
                {
                    Name = "Фильтрация",
                }
            };
            Sort.ItemsSource = ssort;
            Sort.DisplayMemberPath = "Name";
            Sort.SelectedIndex = 2;


        }
        private void Load()
        {
            BookBox.ItemsSource = null;
            BookBox.ItemsSource = book;
            Filtr.ItemsSource = null;
            Filtr.ItemsSource = gener;

        }
        private void Poisc_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Poisc.Text))
            {
                BookBox.ItemsSource = book;
            }
            else
            {
                var byName = book.Where(d => d.Name.ToLower().Contains(Poisc.Text.ToLower()));
                var byAuthor = book.Where(d => d.User.Name.ToLower().Contains(Poisc.Text.ToLower()));
                BookBox.ItemsSource = byName.Union(byAuthor).ToList();
            }

        }

        private void Podrob_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            Book selectBook = btn.DataContext as Book;
            NavigationService.Navigate(new PagePodrob(selectBook));
            if (NavigationService.CanGoForward)
            {
                NavigationService.GoForward();
            }

        }

        private void Spisk_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Sort_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (Sort.SelectedIndex == 0)
            {
                BookBox.ItemsSource = null;
                BookBox.ItemsSource = Core.Context.Book.OrderBy(f => f.Name).ToList();
            }
            else if (Sort.SelectedIndex == 1)
            {
                BookBox.ItemsSource = null;
                BookBox.ItemsSource = Core.Context.Book.OrderByDescending(r => r.Rating).ToList();
            }
            else
            { }
        }

        private void Filtr_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedGenre = Filtr.SelectedItem as Gener;

            if (selectedGenre == null)
            {
                BookBox.ItemsSource = book;
                return;
            }

            var filteredBooks = book.Where(b => b.BookGener.Any(bg => bg.IdGener == selectedGenre.Id)).ToList();

            BookBox.ItemsSource = filteredBooks;
        }
    }
}
