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
            if (AffUser.Auser != null)
            {
                BookZabr.ItemsSource = books.Where(a => a.IdStatus == 1 && a.IdUser == AffUser.Auser.Id).Select(b=>b.Book);
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
            UserBook SenderUserBook = btn.DataContext as UserBook;

            SenderUserBook.IdStatus = 2;
            Core.Context.SaveChanges();

            MessageBox.Show("Вы перенесли книгу в другой список");

        }

        private void Read_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            UserBook SenderUserBook = btn.DataContext as UserBook;

            SenderUserBook.IdStatus = 3;
            Core.Context.SaveChanges();

            MessageBox.Show("Вы перенесли книгу в другой список");
        }

        private void Ok_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            UserBook SenderUserBook = btn.DataContext as UserBook;

            SenderUserBook.IdStatus = 4;
            Core.Context.SaveChanges();

            MessageBox.Show("Вы перенесли книгу в другой список");
        }

        private void Bros_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            UserBook SenderUserBook = btn.DataContext as UserBook;

            SenderUserBook.IdStatus = 1;
            Core.Context.SaveChanges();
        }
    }
}
