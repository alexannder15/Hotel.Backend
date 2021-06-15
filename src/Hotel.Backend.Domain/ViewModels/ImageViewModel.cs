﻿namespace Hotel.Backend.Domain.ViewModels
{
    public class ImageViewModel
    {
        public int Id { get; set; }

        public string ImageUrl { get; set; }

        public int HotelId { get; set; }

        public HotelViewModel Hotel { get; set; }
    }
}
