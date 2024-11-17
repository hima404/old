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
    /// Interaction logic for All_Movies.xaml
    /// </summary>
    public partial class All_Movies : Page
    {
        MovieEntities1 db = new MovieEntities1();
        public All_Movies()
        {
            InitializeComponent();
            var movg = db.movies
                .Select(x => new { x.id, x.names, x.prod, x.years }).ToList();
           MoviesDataGrid.ItemsSource = movg;


           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            var mo = int.Parse(movid.Text);
            var cc = db.movies.Where(x=> x.id == mo).FirstOrDefault();
            Movie_details d = new Movie_details(cc.names , cc.category , cc.years , cc.prod);
            NavigationService.Navigate(d);



        }
    }
}
