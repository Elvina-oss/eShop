using eShop.Data;
using eShop.Data.Services;
using eShop.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShop.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly ICategoryService _service;
        public CategoriesController(ICategoryService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var allCategories = await _service.GetAllAsync();
            return View(allCategories);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("CategoryName")]Category category)
        {
            if (!ModelState.IsValid) return View(category);
            await _service.AddAsync(category);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Details(int id)
        {
            var categoryDetails = await _service.GetByIdAsync(id);
            if (categoryDetails == null) return View("NotFound");
            return View(categoryDetails);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var categoryDetails = await _service.GetByIdAsync(id);
            if (categoryDetails == null) return View("NotFound");
            return View(categoryDetails);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("Id,CategoryName")] Category category)
        {
            if (!ModelState.IsValid) return View(category);
            await _service.UpdateAsync(id, category);
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Delete(int id)
        {
            var categoryDetails = await _service.GetByIdAsync(id);
            if (categoryDetails == null)
                return View("NotFound");

            return View(categoryDetails);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var categoryDetails = await _service.GetByIdAsync(id);
            if (categoryDetails == null)
                return View("NotFound");
            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }

    }
}
