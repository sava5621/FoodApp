namespace FoodApp.Services
{
    public class FoodServices
    {
        public static ObservableCollection<BookingList> BookingData;

        public  static  async void GetBookingData()
        {
            using var stream = await FileSystem.OpenAppPackageFileAsync("bookList.json");
            using var reader = new StreamReader(stream);
            var contents = await reader.ReadToEndAsync();
            BookingData =new(JsonSerializer.Deserialize<List<BookingList>>(contents));
        }
        public static void Concatenate(ref ObservableCollection<BookingList> BD)
        {
            BD = ref BookingData;
        }
    }
}
