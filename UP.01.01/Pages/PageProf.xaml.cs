using System.Collections.Generic;
using System.Windows.Controls;

namespace UP._01._01.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageProf.xaml
    /// </summary>
    public partial class PageProf : Page
    {
        List<User> users;
        public User user { get; set; }
        public PageProf()
        {
            InitializeComponent();
            if (AffUser.Auser != null)
            {
                NameUser.Text = AffUser.Auser.Name;
                Login.Text = AffUser.Auser.Login;
            }

        }
    }
}
