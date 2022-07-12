using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodApp.ViewModel
{
    [QueryProperty(nameof(BookingItem), "BookingItem")]
    public partial class DetailsRestaurantViewModel : BaseViewModel
    {
        public DetailsRestaurantViewModel()
        {

        }
        [ObservableProperty]
        BookingList bookingItem;
        public ObservableCollection<BookingList> bookingListI { get; set; } = FoodServices.BookingData;
        [RelayCommand]
        async Task GoToDetailsItem()
        {
            await Shell.Current.DisplayAlert("Error!", bookingListI.Count.ToString(), "OK");

        }
    }
}
