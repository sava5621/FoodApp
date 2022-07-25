using FoodApp.Model.View;
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
        [ObservableProperty]
        string fI = FoodServices.BookingData[0].fullSizeImage;
        public ObservableCollection<BookingList> bookingListI { get; set; } = FoodServices.BookingData;

    }
}
