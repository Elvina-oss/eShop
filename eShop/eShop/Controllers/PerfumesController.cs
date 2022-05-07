using eShop.Data;
using eShop.Data.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShop.Controllers
{
    public class PerfumesController : Controller
    {
        private readonly IPerfumesService _service;
        public PerfumesController(IPerfumesService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var allPerfumes = await _service.GetAllAsync(n => n.Brand);
            return View(allPerfumes);
        }

        public async Task<IActionResult> Details(int id)
        {
            var perfumeDetails = await _service.GetPerfumeByIdAsync(id);
            return View(perfumeDetails);
        }

        public async Task<IActionResult> Create()
        {
            var perfumeDropdownsData = await _service.GetNewPerfumeDropdownsValues();
            ViewBag.Brands = new SelectList(perfumeDropdownsData.Brands, "Id", "BrandName");
            ViewBag.Categories = new SelectList(perfumeDropdownsData.Categories, "Id", "CategoryName");
            return View();
        }
    }
}
