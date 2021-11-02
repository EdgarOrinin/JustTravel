using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using TravelAroundRussia.Models;

namespace TravelAroundRussia.Views
{
    public partial class TourListWindow : Window
    {
        public TourListWindow()
        {
            InitializeComponent();

            Tours.ItemsSource = (Application.Current as App).TourList;

            var view = (CollectionView)CollectionViewSource.GetDefaultView(Tours.ItemsSource);
            view.Filter = Filter;
        }

        private void Searching(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            CollectionViewSource.GetDefaultView(Tours.ItemsSource).Refresh();
        }

        private bool Filter(object item)
        {
            Tour tour = (item as Tour);
            if (Search.Text.Length == 0 && TourTypes.SelectedIndex == -1)
                return true;

            if (TourTypes.SelectedIndex == -1)
            {
                if ((tour.Name.Contains(Search.Text) || tour.Description.Contains(Search.Text)))
                    return true;
            }
            
            else if (Search.Text.Length == 0 && TourTypes.SelectedIndex != -1)
            {
                if (tour.Type == TourTypes.Text)
                {
                    return true;
                }
            }

            if (TourTypes.SelectedIndex == -1 && tour.Type == TourTypes.Text)
            {
                return true;
            }

            if ((tour.Name.Contains(Search.Text) || tour.Description.Contains(Search.Text)) && tour.Type == TourTypes.Text)
                return true;

            return false;
        }

        private void Filtering(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            CollectionViewSource.GetDefaultView(Tours.ItemsSource).Refresh();
        }
    }
}
