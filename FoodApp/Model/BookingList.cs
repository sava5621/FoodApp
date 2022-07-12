using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodApp.Model
{
    public class BookingList : CollectionData
    {
        public BookingList(string title, string additionally, string image, string fullSizeImage, string time_open )
        {
            this.title = title;
            this.additionally = additionally;
            this.one_line_additionally = additionally.Replace('\n', ' ');
            this.image = image;
            this.fullSizeImage = fullSizeImage;
            this.time_open = time_open;

        }
        public string one_line_additionally { get; set; }
        public string fullSizeImage { get; set; }
        public string time_open { get; set; }
    }
}
