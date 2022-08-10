using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace FoodApp.Services
{
    public class FoodServices
    {
        public static ObservableCollection<BookingList> BookingData = new();
        public static ObservableCollection<Carousel_advertisement> carousel_advertisement = new();
        public static ObservableCollection<Carousel_offers> carousel_offers = new();
        public static ObservableCollection<CollectionViewRestorsan> сollectionViewRestorsan = new();
        TokenServices tokenServices;
        HttpClient httpClient;
        public string conectionSTR = "https://u1648633.plsk.regruhosting.ru/";
        public FoodServices()
        {
            this.httpClient = new HttpClient();
            this.tokenServices = new TokenServices();
            GetAll();
        }
        public async void GetAll()
        {
            await GetCarouselAdv();
            await GetCarouselOff();
            await GetBookingData();
            await GetCollectionViewRestorsan();
        }
        public async Task<ObservableCollection<CollectionViewRestorsan>> GetCollectionViewRestorsan()
        {
            foreach (var i in BookingData)
            {
                сollectionViewRestorsan.Add(new CollectionViewRestorsan(i.title,
                                                                        i.additionally,
                                                                        i.image,
                                                                        i.longitude,
                                                                        i.latitude));
            }
            return сollectionViewRestorsan;
        }
        public async Task<ObservableCollection<Carousel_offers>> GetCarouselOff()
        {
            if (carousel_offers?.Count > 0)
                carousel_offers.Clear();

            var response = await httpClient.GetAsync(conectionSTR + "ListData/carousel_off");
            if (response.IsSuccessStatusCode)
            {
                List<FoodApi.Model.Services.Food> ansver = await response.Content.ReadFromJsonAsync<List<FoodApi.Model.Services.Food>>();
                foreach (var i in ansver)
                {
                    carousel_offers.Add(new Carousel_offers(i.title,
                                                            i.additionally,
                                                            i.image));
                }
            }

            return carousel_offers;
        }
        public async Task<ObservableCollection<Carousel_advertisement>> GetCarouselAdv()
        {
            if (carousel_advertisement?.Count > 0)
                carousel_advertisement.Clear();

            var response = await httpClient.GetAsync(conectionSTR + "ListData/carousel_adv");
            if (response.IsSuccessStatusCode)
            {
                List<FoodApi.Model.Services.Carousel_advertisement> ansver = await response.Content.ReadFromJsonAsync<List<FoodApi.Model.Services.Carousel_advertisement>>();
                foreach (var i in ansver)
                {
                    carousel_advertisement.Add(new Carousel_advertisement(i.icon,
                                                    i.title,
                                                    i.additionally,
                                                    i.image,
                                                    i.color_gr_start,
                                                    i.color_gr_end));
                }
            }

            return carousel_advertisement;
        }
        public async Task<ObservableCollection<BookingList>> GetBookingData()
        {
            if (BookingData?.Count > 0)
                BookingData.Clear();
            HttpContent content = new StringContent(await tokenServices.GetAccToken());
            content.Headers.ContentType = MediaTypeHeaderValue.Parse("application/json");
            var response = await httpClient.PostAsync(conectionSTR + "ListData/User_has_restoran", content);
            if (response.IsSuccessStatusCode)
            {
                string s = await response.Content.ReadAsStringAsync();
                List<FoodApi.Model.Services.Restoran> ansver = await response.Content.ReadFromJsonAsync<List<FoodApi.Model.Services.Restoran>>();
                foreach (var i in ansver)
                {
                    BookingData.Add(new BookingList(i.title,
                                                    i.location,
                                                    i.image,
                                                    i.fullSizeImage,
                                                    i.open,
                                                    i.longitude,
                                                    i.latitude));
                }
            }

            return BookingData;
        }
    }
}
