using eShop.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eShop.Models
{
    public class Brand: IEntityBase
    {
        [Key]
        public int Id { get; set; }
        [Display(Name ="Логотип бренда")]
        [Required(ErrorMessage = "Необходим логотипа бренда")]
        public string BrandPictureURL { get; set; }
        [Display(Name ="Название")]
        [Required(ErrorMessage = "Необходимо имя бренда")]
        public string BrandName { get; set; }
        [Display(Name = "Описание")]
        [Required(ErrorMessage = "Необходимо описание бренда")]
        public string Description { get; set; }

        public List<Perfume> Perfumes{ get; set; }
    }
}
