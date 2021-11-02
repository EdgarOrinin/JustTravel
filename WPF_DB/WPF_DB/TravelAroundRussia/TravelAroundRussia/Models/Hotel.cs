using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelAroundRussia.Models
{
    public class Hotel
    {
        public Hotel(int ID, string name, int starts, string description, string countryCode, int tourCount = 0)
        {
            this.ID = ID;
            Name = name;
            Starts = starts;
            Description = description;
            CountryCode = countryCode;
        }

        public int ID { get; }
        public string Name { get; }
        public int Starts { get; }
        public string Description { get; }
        public string CountryCode { get; }
        public int TourCount { get; }

    }
}
