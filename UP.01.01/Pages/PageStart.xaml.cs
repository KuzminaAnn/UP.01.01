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
        public PageStart()
        {
            InitializeComponent();
            Load();
        }
        private void Load()
        {
            BookBox.ItemsSource = null;
            BookBox.ItemsSource = book;

        }
        private void Poisc_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(Poisc.Text))
            {
                BookBox.ItemsSource = book;
            }
            else
            {
                BookBox.ItemsSource = book.Where(d => d.Name.ToLower().Contains(Poisc.Text.ToLower())).ToList();
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
    }
}
