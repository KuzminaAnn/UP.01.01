using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;

namespace UP._01._01.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageBan.xaml
    /// </summary>
    public partial class PageBan : Page
    {
        List<Book> books;
        public Book book { get; set; }

        public PageBan(Book b)
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
            if ((Autor.IsChecked == true && Text.Text != null) || (Book.IsChecked == true && Text.Text != null))
            {
                if (Autor.IsChecked == true)
                {
                    Complaint newComplaint = new Complaint
                    {
                        IdUser = AffUser.Auser.Id,
                        IdAuthor = book.IdAuthor,
                        IdBook = null,
                        Text = Text.Text
                    };
                    Core.Context.Complaint.Add(newComplaint);
                    Core.Context.SaveChanges();
                    MessageBox.Show("Жалоба отправлена");
                }
                else if (Book.IsChecked == true)
                {
                    Complaint newComplaint = new Complaint
                    {
                        IdUser = AffUser.Auser.Id,
                        IdAuthor = null,
                        IdBook = book.Id,
                        Text = Text.Text
                    };
                    Core.Context.Complaint.Add(newComplaint);
                    Core.Context.SaveChanges();
                    MessageBox.Show("Жалоба отправлена");
                }
            }
            else
                MessageBox.Show("Заполните все поля!");

        }
    }
}
