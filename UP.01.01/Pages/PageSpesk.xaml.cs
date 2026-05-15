using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Navigation;

namespace UP._01._01.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageSpesk.xaml
    /// </summary>
    public partial class PageSpesk : Page
    {
        List<Book> book = Core.Context.Book.ToList();
        List<UserBook> books = Core.Context.UserBook.ToList();
        public UserBook genreb { get; set; }
        public PageSpesk()
        {
            InitializeComponent();
            Load();

        }

        private void Load()
        {
            if (AffUser.Auser != null)
            {
                BookZabr.ItemsSource = null;
                BookPlan.ItemsSource = null;
                BookRead.ItemsSource = null;
                BookOkRead.ItemsSource = null;
                BookZabr.ItemsSource = books.Where(a => a.IdStatus == 1 && a.IdUser == AffUser.Auser.Id).Select(b => b.Book);
                BookPlan.ItemsSource = books.Where(a => a.IdStatus == 2 && a.IdUser == AffUser.Auser.Id).Select(b => b.Book);
                BookRead.ItemsSource = books.Where(a => a.IdStatus == 3 && a.IdUser == AffUser.Auser.Id).Select(b => b.Book);
                BookOkRead.ItemsSource = books.Where(a => a.IdStatus == 4 && a.IdUser == AffUser.Auser.Id).Select(b => b.Book);
            }
        }

        private void BookPlan_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

            Book selectBook = BookPlan.SelectedItem as Book;
            if (selectBook != null)
                NavigationService.Navigate(new PagePodrob(selectBook));

        }
        private void BookPlan_MouseDoubleClick1(object sender, MouseButtonEventArgs e)
        {

            Book selectBook = BookZabr.SelectedItem as Book;
            if (selectBook != null)
                NavigationService.Navigate(new PagePodrob(selectBook));

        }
        private void BookPlan_MouseDoubleClick2(object sender, MouseButtonEventArgs e)
        {

            Book selectBook = BookRead.SelectedItem as Book;
            if (selectBook != null)
                NavigationService.Navigate(new PagePodrob(selectBook));

        }
        private void BookPlan_MouseDoubleClick3(object sender, MouseButtonEventArgs e)
        {

            Book selectBook = BookOkRead.SelectedItem as Book;
            if (selectBook != null)
                NavigationService.Navigate(new PagePodrob(selectBook));

        }

        private void Plan_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            Book selectBook = btn.DataContext as Book;

            UserBook bk = Core.Context.UserBook.FirstOrDefault(a => a.IdBook == selectBook.Id && a.IdUser == AffUser.Auser.Id);
            bk.IdStatus = 2;
            Core.Context.SaveChanges();
            MessageBox.Show("Вы перенесли книгу в другой список");
            Load();

        }

        private void Read_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            Book selectBook = btn.DataContext as Book;

            UserBook bk = Core.Context.UserBook.FirstOrDefault(a => a.IdBook == selectBook.Id && a.IdUser == AffUser.Auser.Id);
            bk.IdStatus = 3;
            Core.Context.SaveChanges();
            MessageBox.Show("Вы перенесли книгу в другой список");
            Load();
        }

        private void Ok_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            Book selectBook = btn.DataContext as Book;

            UserBook bk = Core.Context.UserBook.FirstOrDefault(a => a.IdBook == selectBook.Id && a.IdUser == AffUser.Auser.Id);
            bk.IdStatus = 4;
            Core.Context.SaveChanges();
            MessageBox.Show("Вы перенесли книгу в другой список");
            Load();
        }

        private void Bros_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            Book selectBook = btn.DataContext as Book;

            UserBook bk = Core.Context.UserBook.FirstOrDefault(a => a.IdBook == selectBook.Id && a.IdUser == AffUser.Auser.Id);
            bk.IdStatus = 1;
            Core.Context.SaveChanges();
            MessageBox.Show("Вы перенесли книгу в другой список");
            Load();
        }
    }
}
