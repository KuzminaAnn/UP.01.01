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

namespace UP._01._01.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageAtour.xaml
    /// </summary>
    public partial class PageAtour : Page
    {
        List<User> users;
        List<Book> books = Core.Context.Book.ToList();
        public User user { get; set; }
        public Book book { get; set; }
        public PageAtour()
        {
            InitializeComponent();
            
        }
        private void Load()
        {
            if (AffUser.Auser != null)
            {
                NameAutor.Text = AffUser.Auser.Name;
                books = Core.Context.Book.Where(g => g.IdAuthor == AffUser.Auser.Id).ToList();
                BookBox.ItemsSource = books;
            }
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Load();
        }

        private void Freez_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PageFreez());
            if (NavigationService.CanGoForward)
            {
                NavigationService.GoForward();
            }
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PageAddBook());
            if (NavigationService.CanGoForward)
            {
                NavigationService.GoForward();
            }
        }
    }
}
