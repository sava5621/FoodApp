﻿namespace FoodApi.Model.Services
{
    public class Food
    {
        public int id_food { get; set; }
        public string title { get; set; }
        public string additionally { get; set; }
        public string image { get; set; }
        public int Restoran_idRestoran { get; set; }
        public int Restoran_id_restoran { get; set; }
    }
}
