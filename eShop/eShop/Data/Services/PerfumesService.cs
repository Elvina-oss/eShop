using eShop.Data.Base;
using eShop.Data.ViewModels;
using eShop.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShop.Data.Services
{
    public class PerfumesService : EntityBaseRepository<Perfume>, IPerfumesService
    {
        private readonly AppDbContext _context;
        public PerfumesService(AppDbContext context) : base(context)
        {
            _context = context; 
        }

        public async Task<NewPerfumeDropdownsVM> GetNewPerfumeDropdownsValues()
        {
            var responce = new NewPerfumeDropdownsVM()
            {
                Brands = await _context.Brands.OrderBy(n => n.BrandName).ToListAsync(),
                Categories = await _context.Categories.OrderBy(n => n.CategoryName).ToListAsync()
            }; 
            return responce;    
        }

        public async Task<Perfume> GetPerfumeByIdAsync(int id)
        {
            var perfumeDetails = await _context.Perfumes
                .Include(b => b.Brand)
                .Include(cp => cp.Category_Perfumes).ThenInclude(c => c.Category)
                .FirstOrDefaultAsync(n => n.Id == id);
            return perfumeDetails;

        }
    }
}
