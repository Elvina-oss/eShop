using eShop.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShop.Controllers
{
    public class BrandsController : Controller
    {
        private readonly AppDbContext _context;
        public BrandsController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var allBrands = _context.Brands.ToList();
            return View();
        }
    }
}
