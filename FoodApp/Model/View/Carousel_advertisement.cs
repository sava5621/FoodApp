namespace FoodApp.Model.View
{
    public class Carousel_advertisement : CollectionData
    {
        public Carousel_advertisement(string icon, string title, string additionally, string image, string color_gr_start, string color_gr_end)
        {
            this.icon = icon;
            this.title = title;
            this.additionally = additionally;
            this.image = image;
            this.gradientBrush = new LinearGradientBrush();
            var buff = new GradientStopCollection();
            gradientBrush.GradientStops.Add(new GradientStop(Color.FromHex(color_gr_start), (float)0.4));
            gradientBrush.GradientStops.Add(new GradientStop(Color.FromHex(color_gr_end), (float)1));
        }
        public string icon { get; set; }
        public LinearGradientBrush gradientBrush { get; set; }
    }
}
