﻿using Hotel.Backend.Domain.Models;
using Hotel.Backend.Infrastructure.Repository;

namespace Hotel.Backend.WebApi.Interfaces
{
    public interface IImageService : IRepository<Image>
    {
    }
}
