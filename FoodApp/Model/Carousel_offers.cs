using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodApp.Model
{
    public class Carousel_offers : CollectionData
    {
        public Carousel_offers(string title, string additionally, string image)
        {
            this.title = title;
            this.additionally = additionally;
            this.image = image;
        }
    }
}
