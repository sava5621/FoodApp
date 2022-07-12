namespace FoodApp.ViewModel
{
    public partial class BookingScreenViewModel : BaseViewModel
    {
        //TODO: сервис
        public ObservableCollection<BookingList> bookingList { get; set; } = FoodServices.BookingData;
        [RelayCommand]
        async Task GoToDetails(BookingList bookingItem)
        {
            if (bookingList == null)
                return;
            await Shell.Current.GoToAsync(nameof(DetailsRestaurant), true, new Dictionary<string, object>
            {
                {"BookingItem", bookingItem }
            });
        }
    }
}
