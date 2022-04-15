using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eShop.Models
{
    public class Brand
    {
        [Key]
        public int Id { get; set; }
        public string BrandPictureURL { get; set; }
        public string BrandName { get; set; }
        public string Description { get; set; }

        public List<Perfume> Perfumes{ get; set; }
    }
}
