using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;

namespace WebApplication2.Repositories
{
    public interface IClanRepository<T>
    {
        Task<IEnumerable<T>> ReadAllAsync();
        Task<T> ReadOneAsync(string clanName);
        Task<T> CreateAsync(T clan);
        Task<T> UpdateAsync(T clan);
        Task<T> DeleteAsync(string clanName);
    }
}
