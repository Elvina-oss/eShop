using eShop.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShop.Controllers
{
    public class PerfumesController : Controller
    {
        private readonly AppDbContext _context;
        public PerfumesController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allPerfumes = await _context.Perfumes.Include(n => n.Category_Perfumes).ToListAsync();
            return View(allPerfumes);
        }
    }
}
