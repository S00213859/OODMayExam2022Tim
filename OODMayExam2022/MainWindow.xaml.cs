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

namespace OODMayExam2022
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<RentalProperty> allRentals;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            RentalData db = new RentalData();

            var query = from r in db.Rentals
                        orderby r.Location
                        select r;

            allRentals = query.ToList();

            lbxRentalPriceType.ItemsSource = allRentals;
        }

        private void lbxRentalPriceType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            //determine what was selected
            RentalProperty selected = lbxRentalPriceType.SelectedItem as RentalProperty;

            //check not null
            if (selected != null)
            {
                //update display
                tblkRentalDesc.Text = selected.Description;
            }
        }
    }
}
