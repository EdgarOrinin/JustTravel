using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace TravelAroundRussia.Models
{
    public class Tour
    {
        public Tour(int iD, string description, string name, ImageSource imagePreview, int price, int ticketCount, bool isActual, string type)
        {
            ID = iD;
            Description = description;
            Name = name;
            Price = price;
            TicketCount = ticketCount;
            IsActual = isActual;
            Type = type;


            if (imagePreview == null)
            {
                BitmapImage logo = new BitmapImage(new System.Uri("/TravelAroundRussia;component/Resources/TourNotFound.png", System.UriKind.Relative));
                ImagePreview = logo;
            }
        }

        public int ID { get; set; }
        public string Description { get; set; }

        public string Name { get; set; }
        public ImageSource ImagePreview { get; set; }
        public int Price { get; set; }
        public int TicketCount { get; set; }
        public bool IsActual { get; set; }

        public string Type { get; set; }
    }
}
