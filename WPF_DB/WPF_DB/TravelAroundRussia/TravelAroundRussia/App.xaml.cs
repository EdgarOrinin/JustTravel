using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using TravelAroundRussia.Models;

namespace TravelAroundRussia
{
    public partial class App : Application
    {
        public ObservableCollection<Tour> TourList = new ObservableCollection<Tour>
        {
            new Tour(1, "Hello World", "Болгарское наследие", null, 35700, 127, true, "Международный туризм"),
            new Tour(1, "Hello World", "Волшебный Восток", null, 77100, 92, true, "Международный туризм"),
        };

        public ObservableCollection<Hotel> HotelList = new ObservableCollection<Hotel>
        {
            new Hotel(1, "1", 5, "wqejod[weopdw", "RU"),
            new Hotel(2, "2", 3, "wqejod", "RU"),
            new Hotel(3, "3", 8, "wqejod[weopdw", "RU"),
            new Hotel(4, "4", 7, "wqejdw", "RU"),
            new Hotel(6, "6", 6, "wqejod[weopdw", "RU"),
            new Hotel(7, "7", 5, "wqejod[weopdw", "RU"),
    };

        public ObservableCollection<string> CountriesCode = new ObservableCollection<string>
        {
            "ru", "EN", "JP"
        };

        private void Application_Startup(object sender, StartupEventArgs e)
        {
            var Tours = new ToursEntities();
            
        }
    }
}
