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
        List<Applications> applications = Core.Context.Applications.ToList();
        List<Complaint> complaints = Core.Context.Complaint.ToList();
        List<Book> books = Core.Context.Book.ToList();
        public User user { get; set; }
        public Applications application { get; set; }
        public Complaint complaint { get; set; }
        public Book book { get; set; }
        public PageAdmin()
        {
            InitializeComponent();
        }
        private void Load()
        {
            if (AffUser.Auser != null)
            {
                NameAdmin.Text = AffUser.Auser.Name;
                Applic.ItemsSource = applications;
                Comp.ItemsSource = complaints;
                Bok.ItemsSource = books;
                Usr.ItemsSource = users;
            }
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Load();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button btn = sender as Button;
            Applications sApp = btn.DataContext as Applications;
            //Applications removeApplications = Core.Context.Applications.First(u => u.Id = sApp.Id);

            //Core.Context.Applications.Remove(removeApplications); 
            //Core.Context.SaveChanges();
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
            if (RoleUser.IdRole == 1)
            {
                RoleUser.IdRole = 2;
                Load();
            }
            else if (RoleUser.IdRole == 2)
            {
                RoleUser.IdRole = 1;
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
    }
}
