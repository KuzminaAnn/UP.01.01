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
    /// Логика взаимодействия для PageAddBook.xaml
    /// </summary>
    public partial class PageAddBook : Page
    {
        public PageAddBook()
        {
            InitializeComponent();
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
            Book newBook = new Book
            {
                Name = Name.Text,
                Description = Desc.Text,
                Image = Image.Text,
                IdAuthor = AffUser.Auser.Id,
                Rating = 0,
                Freez = false
            };
            Core.Context.Book.Add(newBook);
            Core.Context.SaveChanges();
            MessageBox.Show("Книга добавлена!");
        }
    }
}
