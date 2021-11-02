using System.Windows;

namespace TravelAroundRussia.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void OpenTourListWindow(object sender, RoutedEventArgs e)
        {
            new TourListWindow().ShowDialog();
        }

        private void OpenHotelListWindow(object sender, RoutedEventArgs e)
        {
            new HotelListWindow().ShowDialog();
        }
    }
}
