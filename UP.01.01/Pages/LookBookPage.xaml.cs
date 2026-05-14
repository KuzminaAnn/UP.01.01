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
    /// Логика взаимодействия для LookBookPage.xaml
    /// </summary>
    public partial class LookBookPage : Page
    {
        public Book book { get; set; }
        public LookBookPage(Book book)
        {
            InitializeComponent();
            this.book = book;
            DataContext = book;
            
        }
    }
}
