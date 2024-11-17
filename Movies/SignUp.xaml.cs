using Movies.Properties;
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

namespace Movies
{
    /// <summary>
    /// Interaction logic for SignUp.xaml
    /// </summary>
    public partial class SignUp : Page
    {
        MovieEntities1 db = new MovieEntities1();
        public SignUp()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            user rec = new user();
            Login log = new Login();
            rec.email = EmailTextBox.Text;
            rec.password = PasswordBox.Password;
            rec.names = NameTextBox.Text;
            if (PasswordBox.Password == ConfirmPasswordBox.Password)
            {
                NavigationService.Navigate(log);
            }
            else
            {
                MessageBox.Show("password not matching");
            }
            db.users.Add(rec);
            db.SaveChanges();
        }
    }
}
