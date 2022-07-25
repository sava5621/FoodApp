namespace FoodApp.Model.View
{
    public class Carousel_offers : CollectionData
    {
        public Carousel_offers(string title,
                               string additionally,
                               string image)
        {
            this.title = title;
            this.additionally = additionally;
            this.image = image;
        }
    }
}
