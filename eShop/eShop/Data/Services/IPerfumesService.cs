using eShop.Data.Base;
using eShop.Data.ViewModels;
using eShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShop.Data.Services
{
    public interface IPerfumesService : IEntityBaseRepository<Perfume>
    {
        Task<Perfume> GetPerfumeByIdAsync(int id);
        Task<NewPerfumeDropdownsVM> GetNewPerfumeDropdownsValues();
    }
}
