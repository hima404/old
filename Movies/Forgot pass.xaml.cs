using Movies.Properties;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
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
    /// Interaction logic for Forgot_pass.xaml
    /// </summary>
    public partial class Forgot_pass : Page
    {
        MovieEntities1 db = new MovieEntities1();
        public Forgot_pass()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Login login = new Login();
            string email = EmailTextBox.Text;
            string password = NewPasswordBox.Password;
           
            user rec = new user();
            
            rec = db.users.FirstOrDefault(x => x.email == email );
            
            
            if (rec != null)
            {
                rec.email = EmailTextBox.Text;
                rec.password = NewPasswordBox.Password;
                db.users.AddOrUpdate(rec);
                db.SaveChanges();
            }
            else
            {
                MessageBox.Show("password not match or email not found");
            }

            if (NewPasswordBox.Password == ConfirmPasswordBox.Password)
            {
                NavigationService.Navigate(login);

            }
            else
            {
                MessageBox.Show("password not match or email not found");
            }
          
        }
    }
}
