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
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Page
    {
        MovieEntities1 db = new MovieEntities1();

        public Login()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SignUp sign = new SignUp();
            NavigationService.Navigate(sign);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            All_Movies movi = new All_Movies(); 
            Admin admin = new Admin();  
            string email = Emaill.Text;
            string pass = passtext.Password;
            user rec = db.users.FirstOrDefault(x => x.email == email && x.password == pass);
            if (rec != null)
            {
                NavigationService.Navigate(movi);
            }
          
            if (email == "admin" && pass == "hima")
            {
                NavigationService.Navigate(admin);

            }
            else
            {
                worng.Text = "Wrong password or email";
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Forgot_pass pass = new Forgot_pass();
            NavigationService.Navigate(pass);   
        }
    }
}
