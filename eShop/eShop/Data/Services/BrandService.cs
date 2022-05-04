using eShop.Data.Base;
using eShop.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShop.Data.Services
{
    public class BrandService : EntityBaseRepository<Brand>, IBrandsService
    {
        public BrandService(AppDbContext context) : base(context) { }
   
    }
}
