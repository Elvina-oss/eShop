using eShop.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShop.Data.Services
{
    public class BrandService : IBrandsService
    {
        private readonly AppDbContext _context;
        public BrandService(AppDbContext context)
        {
            _context = context;
        }
        public async Task AddAsync(Brand brand)
        {
            await _context.Brands.AddAsync(brand);
            await _context.SaveChangesAsync();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Brand>> GetAllAsync()
        {
            var result = await _context.Brands.ToListAsync();
            return result;
        }

        

        public async Task<Brand> GetByIdAsync(int id)
        {
            var result = await _context.Brands.FirstOrDefaultAsync(n => n.Id == id);
            return result;
        }

        public Brand Update(int id, Brand newBrand)
        {
            throw new NotImplementedException();
        }
    }
}
