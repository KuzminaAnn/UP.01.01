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
        List<Book> books = Core.Context.Book.ToList();
        public UserBook genreb { get; set; }
        public PageSpesk()
        {
            InitializeComponent();

            foreach (var a in AffUser.Auser.UserBook)
            {
                if (a.IdStatus == 1)
                {
                    BookZabr.ItemsSource = books;
                }
                if (a.IdStatus == 2)
                {
                    BookPlan.ItemsSource = books;
                }
                if (a.IdStatus == 3)
                {
                    BookRead.ItemsSource = books;
                }
                if (a.IdStatus == 4)
                {
                    BookOkRead.ItemsSource = books;
                }
            }
            //    ganre.Text = a.Gener.Name;
            //BookZabr.ItemsSource = books;
            //BookPlan.ItemsSource = books;
            //BookRead.ItemsSource = books;
            //BookOkRead.ItemsSource = books;
        }

    }
}
