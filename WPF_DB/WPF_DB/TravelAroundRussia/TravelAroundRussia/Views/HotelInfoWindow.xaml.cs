using System.Windows;
using TravelAroundRussia.Models;

namespace TravelAroundRussia.Views
{
    public partial class HotelInfoWindow : Window
    {
        public HotelInfoWindow(Hotel hotel)
        {
            InitializeComponent();

            NameE.Text = hotel.Name;
            Star.Text = hotel.Starts.ToString();
            Description.Text = hotel.Description;
            Country.Text = hotel.CountryCode.ToString();

            Country.ItemsSource = (Application.Current as App).CountriesCode;

        }

        public HotelInfoWindow()
        {
            InitializeComponent();
        }

        private void OK_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Cancel_Click_1(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
