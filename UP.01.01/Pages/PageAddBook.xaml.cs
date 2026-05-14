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
        List<Gener> gener = Core.Context.Gener.ToList();
        public PageAddBook()
        {
            InitializeComponent();
            Genr.ItemsSource = gener;
            GenreList.ItemsSource = gener;
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
            //var selectedGenre = Genr.SelectedItem as Gener;
            var selectedGenres = GenreList.SelectedItems.Cast<Gener>().ToList();
            Book newBook = new Book
            {
                Name = Name.Text,
                Description = Desc.Text,
                Image = Image.Text,
                IdAuthor = AffUser.Auser.Id,
                Rating = 0,
                Freez = false
            };
            foreach (var item in selectedGenres) 
                newBook.BookGener.Add(
                    new BookGener{
                    IdBook = newBook.Id,
                    IdGener = item.Id}
                );
            Core.Context.Book.Add(newBook);
            Core.Context.SaveChanges();

            //BookGener link = new BookGener
            //{
            //    IdBook = newBook.Id, 
            //    IdGener = selectedGenre.Id
            //};
            //Core.Context.BookGener.Add(link);
            //Core.Context.SaveChanges();
            MessageBox.Show("Книга добавлена!");
            NavigationService.Navigate(new PageAtour());
            if (NavigationService.CanGoForward)
            {
                NavigationService.GoForward();
            }
        }
    }
}
