using eShop.Data;
using eShop.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eShop.Models
{
    public class Perfume : IEntityBase
    {
        [Key]
        public int Id { get; set; }
        public string PerfumePictureURL { get; set; }
        public string PerfumeName { get; set; }
        public int ReleaseYear { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }

        //Relationships
        //Category
        public List<Category_Perfume> Category_Perfumes { get; set; }
        //Brand
        public int BrandId { get; set; }
        [ForeignKey("BrandId")]
        public Brand Brand { get; set; }
    }
}
