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
    /// Логика взаимодействия для PageRed.xaml
    /// </summary>
    public partial class PageRed : Page
    {
        List<Book> books;
        List<Gener> gener = Core.Context.Gener.ToList();
        public Book book { get; set; }
        public PageRed(Book b)
        {
            InitializeComponent();
            book = b;
            this.DataContext = this;

            Name.Text = book.Name;
            Desc.Text = book.Description;
            Image.Text = book.Image;
            Genr.ItemsSource = gener;

        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PageAtour());
            if (NavigationService.CanGoForward)
            {
                NavigationService.GoForward();
            }
        }

        private void Enter_Click(object sender, RoutedEventArgs e)
        {
            if (Name.Text != book.Name)
            {
                book.Name = Name.Text;
                Core.Context.SaveChanges();
            }
            if (Desc.Text != book.Description)
            {
                book.Description = Desc.Text;
                Core.Context.SaveChanges();
            }
            if (Image.Text != book.Image)
            {
                book.Image = Image.Text;
                Core.Context.SaveChanges();
            }
        }
    }
}
