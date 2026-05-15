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
using static System.Net.Mime.MediaTypeNames;

namespace UP._01._01.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageAdmin.xaml
    /// </summary>
    public partial class PageAdmin : Page
    {
        List<User> users = Core.Context.User.ToList();
        List<Applications> applications;
        List<Complaint> complaints;
        List<Book> books = Core.Context.Book.ToList();
        public User user { get; set; }
        public Applications application { get; set; }
        public Complaint complaint { get; set; }
        public Book book { get; set; }
        public PageAdmin()
        {
            InitializeComponent();
            Load();
        }
        private void Load()
        {
            if (AffUser.Auser != null)
            {
                NameAdmin.Text = AffUser.Auser.Name;
                applications = Core.Context.Applications.ToList();
                complaints = Core.Context.Complaint.ToList();
                Applic.ItemsSource = null;
                Comp.ItemsSource = null;
                Bok.ItemsSource = null;
                Usr.ItemsSource = null;
                Applic.ItemsSource = applications;
                Comp.ItemsSource = complaints;
                Bok.ItemsSource = books;
                Usr.ItemsSource = users;
            }

        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            Applications sApp = btn.DataContext as Applications;
            Applications app = Core.Context.Applications.FirstOrDefault(a => a.Id == sApp.Id);

            Core.Context.Applications.Remove(app);
            Core.Context.SaveChanges();
            Load(); 
            MessageBox.Show("Успешно удалено");
        }
        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            Complaint sApp = btn.DataContext as Complaint;
            Complaint app = Core.Context.Complaint.FirstOrDefault(a => a.Id == sApp.Id);

            Core.Context.Complaint.Remove(app);
            Core.Context.SaveChanges();
            Load();
            MessageBox.Show("Успешно удалено");
        }

        private void Freez_Click(object sender, RoutedEventArgs e)
        {
            Button b = sender as Button;
            Book editBook = b.DataContext as Book;
            if (editBook.Freez == false)
            {
                editBook.Freez = true;

                Load();
            }
            else
            {
                editBook.Freez = false;
                Load();
            }
        }

        private void Rol_Click(object sender, RoutedEventArgs e)
        {
            Button b = sender as Button;
            User RoleUser = b.DataContext as User;
            if (RoleUser.IdRole == 3)
            {
                RoleUser.IdRole = 2;
                Core.Context.SaveChanges();
                Load();
            }
            else if (RoleUser.IdRole == 2)
            {
                RoleUser.IdRole = 3;
                Core.Context.SaveChanges();
                Load();
            }
        }

        private void Fez_Click(object sender, RoutedEventArgs e)
        {
            Button b = sender as Button;
            User editUser = b.DataContext as User;
            if (editUser.Freez == false)
            {
                editUser.Freez = true;

                Load();
            }
            else
            {
                editUser.Freez = false;
                Load();
            }
        }

        private void Applic_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Button bt = sender as Button;
            if (bt != null) {
                Core.Context.Applications.Remove(bt.DataContext as Applications);
                Core.Context.SaveChanges();
            }

        }
    }
}
