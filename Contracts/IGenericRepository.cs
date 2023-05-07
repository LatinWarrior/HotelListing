using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelListing.Contracts
{
    public interface IGenericRepository<T> where T : class
    {
        Task<T> GetAsync(int? id);
        Task<List<T>> GetAllAsync();
        Task<T> AddAsync(T entity);
        Task DeleteAsync(int id);
        Task UpdateAsync(T entity);
        Task<bool> Exists(int id);
    }
}