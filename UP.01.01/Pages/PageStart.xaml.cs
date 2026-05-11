using System;
using System.Collections;
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
    /// Логика взаимодействия для PageStart.xaml
    /// </summary>
    public partial class PageStart : Page
    {
        List<Book> book = Core.Context.Book.ToList();
        public PageStart()
        {
            InitializeComponent();
            Load();
        }
        private void Load()
        {
            BookBox.ItemsSource = null;
            BookBox.ItemsSource = book;
        }
        private void Poisc_TextChanged(object sender, SelectionChangedEventArgs e)
        {
            if if (string.IsNullOrWhiteSpace(Poisc.Text))
                {
                BookBox.ItemsSource = book;
            }
            else
            {
                //Sort.SelectedValue  использовать в LINQ
                BookBox.ItemsSource = book.Where(d => d.name.ToLower().Contains(Poisc.Text.ToLower())).ToList();
                }

        }
    }
}
