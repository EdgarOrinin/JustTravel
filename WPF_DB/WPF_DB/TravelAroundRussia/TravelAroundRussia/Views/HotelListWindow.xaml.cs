using System.Windows;
using TravelAroundRussia.Models;

namespace TravelAroundRussia.Views
{
    public partial class HotelListWindow : Window
    {
        public HotelListWindow()
        {
            InitializeComponent();

            Date.ItemsSource = (Application.Current as App).HotelList;
        }

        private void AddHotel_Click(object sender, RoutedEventArgs e)
        {
            new HotelInfoWindow().ShowDialog();
        }

        private void EditHotel_Click(object sender, RoutedEventArgs e)
        {
            new HotelInfoWindow((Hotel)Date.SelectedItem).ShowDialog();
        }
    }
}
