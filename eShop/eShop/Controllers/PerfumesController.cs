using eShop.Data;
using eShop.Data.Services;
using eShop.Models;
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

        public async Task<IActionResult> Filter(string searchString)
        {
            var allPerfumes = await _service.GetAllAsync(n => n.Brand);
            if (!string.IsNullOrEmpty(searchString))
            {
                var filteredResult = allPerfumes.Where(n => n.PerfumeName.Contains(searchString) 
                || n.Description.Contains(searchString)).ToList();
                return View("Index", filteredResult);
            }
            return View("Index", allPerfumes);
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

        [HttpPost]
        public async Task<IActionResult> Create(NewPerfumeVM perfume)
        {
            if (!ModelState.IsValid)
            {
                var perfumeDropdownsData = await _service.GetNewPerfumeDropdownsValues();
                ViewBag.Brands = new SelectList(perfumeDropdownsData.Brands, "Id", "BrandName");
                ViewBag.Categories = new SelectList(perfumeDropdownsData.Categories, "Id", "CategoryName");
                return View(perfume);
            }
            await _service.AddNewPerfumeAsync(perfume);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit(int id)
        {
            var perfumeDetails = await _service.GetPerfumeByIdAsync(id);    
            if (perfumeDetails == null)
            {
                return View("NotFound");
            }

            var response = new NewPerfumeVM()
            {
                Id = perfumeDetails.Id,
                PerfumePictureURL = perfumeDetails.PerfumePictureURL,
                PerfumeName = perfumeDetails.PerfumeName,
                ReleaseYear = perfumeDetails.ReleaseYear,
                Description = perfumeDetails.Description,
                Price = perfumeDetails.Price,
                CategoryIds = perfumeDetails.Category_Perfumes.Select(n => n.CategoryId).ToList(),
                BrandId = perfumeDetails.BrandId
            };

            var perfumeDropdownsData = await _service.GetNewPerfumeDropdownsValues();
            ViewBag.Brands = new SelectList(perfumeDropdownsData.Brands, "Id", "BrandName");
            ViewBag.Categories = new SelectList(perfumeDropdownsData.Categories, "Id", "CategoryName");
            return View(response);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, NewPerfumeVM perfume)
        {
            if (id != perfume.Id)
                return View("NotFound");
            if (!ModelState.IsValid)
            {
                var perfumeDropdownsData = await _service.GetNewPerfumeDropdownsValues();
                ViewBag.Brands = new SelectList(perfumeDropdownsData.Brands, "Id", "BrandName");
                ViewBag.Categories = new SelectList(perfumeDropdownsData.Categories, "Id", "CategoryName");
                return View(perfume);
            }
            await _service.UpdatePerfumeAsync(perfume);
            return RedirectToAction(nameof(Index));
        }

    }
}
