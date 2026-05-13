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
    /// Логика взаимодействия для PageAdmin.xaml
    /// </summary>
    public partial class PageAdmin : Page
    {
        List<User> users;
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
            }
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Load();
        }
    }
}
