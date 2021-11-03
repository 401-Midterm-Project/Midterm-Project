﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DaytaCare.Models;

namespace DaytaCare.Services
{
    public interface IDaycareRepository
    {
        Task<List<Daycare>> GetAll();

        Task<Daycare> GetById(int id);

        Task Insert(Daycare daycare);

        Task<bool> TryDelete(int id);

        Task<bool> TryUpdate(Daycare daycare);

        Task Insert(Amenity daycareAmenity);
    }
}
