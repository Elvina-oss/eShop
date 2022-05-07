using eShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShop.Data.ViewModels
{
    public class NewPerfumeDropdownsVM
    {
        public NewPerfumeDropdownsVM()
        {
            Brands = new List<Brand>();
            Categories = new List<Category>();
        }
        public List<Brand> Brands { get; set; }
        public List <Category> Categories { get; set; }
    }
}
