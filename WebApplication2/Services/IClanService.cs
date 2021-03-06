﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Services
{
    public interface IClanService<T>
    {
        Task<IEnumerable<T>> ReadAllAsync();
        Task<T> ReadOneAsync(string clanName);
        Task<bool> IsClanExistsAsync(string clanName);
        Task<T> CreateAsync(T clan);
        Task<T> UpdateAsync(T clan);
        Task<T> DeleteAsync(string clanName);
    }
}
