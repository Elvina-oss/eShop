using eShop.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eShop.Models
{
    public class Category:IEntityBase
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Название категории")]
        [Required(ErrorMessage = "Необходимо название категории")]
        public string CategoryName { get; set; }

        //Relationships
        public List<Category_Perfume> Category_Perfumes { get; set; }
    }
}
