﻿namespace Hotel.Backend.Domain.Models
{
    public class Image
    {
        public int Id { get; set; }

        public string ImageUrl { get; set; }

        public int HotelId { get; set; }

        public Hotel Hotel { get; set; }
    }
}
