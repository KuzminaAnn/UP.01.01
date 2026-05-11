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
using UP._01._01.Pages;

namespace UP._01._01
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainBook_Click(object sender, RoutedEventArgs e)
        {
            navframe1.Visibility = Visibility.Hidden;
            navframe.Visibility = Visibility.Visible;
        }

        private void BookSpesk_Click(object sender, RoutedEventArgs e)
        {
            navframe1.Visibility = Visibility.Visible;
            navframe.Visibility = Visibility.Hidden;
        }
    }
}
