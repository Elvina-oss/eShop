using eShop.Data;
using eShop.Models;
using eShop.Data.Services;
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
        private readonly IBrandsService _service;
        public BrandsController(IBrandsService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var allBrands =  await _service.GetAllAsync();
            return View(allBrands);
        }

        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("BrandPictureURL,BrandName,Description")] Brand brand)
        {
            if (!ModelState.IsValid)
            {
                return View(brand);
            }
            await _service.AddAsync(brand);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Details(int id)
        {
            var brandDetails = await _service.GetByIdAsync(id);
            if (brandDetails == null)
                return View("Empty");
            return View(brandDetails);
        }
    }
}
 