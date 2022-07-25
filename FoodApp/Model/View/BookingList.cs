namespace FoodApp.Model.View
{
    public class BookingList : CollectionData
    {
        public BookingList(string title,
                           string additionally,
                           string image,
                           string fullSizeImage,
                           string time_open,
                           string longitude,
                           string latitude)
        {
            this.title = title;
            this.additionally = additionally;
            this.one_line_additionally = additionally.Replace('\n', ' ');
            this.image = image;
            this.fullSizeImage = fullSizeImage;
            this.time_open = time_open;
            this.longitude = longitude;
            this.latitude = latitude;

        }
        public string one_line_additionally { get; set; }
        public string fullSizeImage { get; set; }
        public string time_open { get; set; }
        public string longitude { get; set; }
        public string latitude { get; set; }
    }
}
