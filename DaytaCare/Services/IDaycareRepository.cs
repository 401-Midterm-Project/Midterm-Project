﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DaytaCare.Models;

namespace DaytaCare.Services
{
    public interface IDaycareRepository
    {
        Task<List<Daycare>> GetAll();
    }
}
