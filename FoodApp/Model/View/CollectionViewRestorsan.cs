namespace FoodApp.Model.View
{
    public class CollectionViewRestorsan : CollectionData
    {
        public CollectionViewRestorsan(string title,
            string additionally,
            string image,
            string longitude,
            string latitude)
        {
            this.title = title;
            this.additionally = additionally;
            this.image = image;

        }
        public string longitude { get; set; }
        public string latitude { get; set; }
    }
}
