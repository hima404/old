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
    /// Interaction logic for Movie_details.xaml
    /// </summary>
    public partial class Movie_details : Page
    {
        public Movie_details(string names , string category , string years , string prod)
        {
            InitializeComponent();
            NameTextBox.Text = names;
            CategoryTextBox.Text = category;
            ProducerTextBox.Text = prod;
        }
    }
}
