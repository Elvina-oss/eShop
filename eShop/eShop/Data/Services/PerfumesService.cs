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

        public async Task AddNewPerfumeAsync(NewPerfumeVM data)
        {
            var newPerfume = new Perfume()
            {
                PerfumeName = data.PerfumeName,
                PerfumePictureURL = data.PerfumePictureURL,
                ReleaseYear = data.ReleaseYear,
                Description = data.Description,
                Price = data.Price,
                BrandId = data.BrandId
            };
            await _context.Perfumes.AddAsync(newPerfume);
            await _context.SaveChangesAsync();
            foreach(var categoryId in data.CategoryIds)
            {
                var newCategoryPerfume = new Category_Perfume()
                {
                    PerfumeId = newPerfume.Id,
                    CategoryId = categoryId
                };
                await _context.Category_Perfumes.AddAsync(newCategoryPerfume);
            }
            await _context.SaveChangesAsync();
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

        public async Task UpdatePerfumeAsync(NewPerfumeVM data)
        {
            var dbPerfume = await _context.Perfumes.FirstOrDefaultAsync(n => n.Id == data.Id);
            if (dbPerfume != null)
            {

                dbPerfume.PerfumeName = data.PerfumeName;
                dbPerfume.PerfumePictureURL = data.PerfumePictureURL;
                dbPerfume.ReleaseYear = data.ReleaseYear;
                dbPerfume.Description = data.Description;
                dbPerfume.Price = data.Price;
                dbPerfume.BrandId = data.BrandId;
                
                await _context.SaveChangesAsync();
            }

            var existingCategoriesDb = _context.Category_Perfumes.Where(n => n.PerfumeId == data.Id).ToList();
            _context.Category_Perfumes.RemoveRange(existingCategoriesDb);
            await _context.SaveChangesAsync();

            foreach (var categoryId in data.CategoryIds)
            {
                var newCategoryPerfume = new Category_Perfume()
                {
                    PerfumeId = data.Id,
                    CategoryId = categoryId
                };
                await _context.Category_Perfumes.AddAsync(newCategoryPerfume);
            }
            await _context.SaveChangesAsync();
        }
    }
}
