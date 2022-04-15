using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eShop.Models
{
    public class Category_Perfume
    {
        public int PerfumeId { get; set; }
        public Perfume Perfume { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
