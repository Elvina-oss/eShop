using eShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShop.Data.Services
{
    public interface IBrandsService
    {
        Task<IEnumerable<Brand>> GetAllAsync();
        Task<Brand> GetByIdAsync(int id);
        Task AddAsync(Brand brand);
        Brand Update(int id, Brand newBrand);
        void Delete(int id);
    }
}
