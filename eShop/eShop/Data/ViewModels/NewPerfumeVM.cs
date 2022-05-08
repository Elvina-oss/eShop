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
    public class NewPerfumeVM
    {
        public int Id { get; set; }
        [Display(Name = "Фото")]
        [Required(ErrorMessage ="Необходима фотография")]
        public string PerfumePictureURL { get; set; }
        [Display(Name = "Название")]
        [Required(ErrorMessage = "Необходимо имя")]
        public string PerfumeName { get; set; }
        [Display(Name = "Год выпуска")]
        [Required(ErrorMessage = "Необходим год выпуска")]
        [Range(1900, 2022, ErrorMessage ="Некорректный год")]
        public int ReleaseYear { get; set; }
        [Display(Name = "Описание")]
        [Required(ErrorMessage = "Необходимо описание")]
        public string Description { get; set; }
        [Display(Name = "Цена")]
        [Required(ErrorMessage = "Необходима цена")]
        public double Price { get; set; }
        [Display(Name = "Категории")]
        [Required(ErrorMessage = "Необходимо выбрать категорию")]
        public List<int> CategoryIds { get; set; }
        [Display(Name = "Бренд")]
        [Required(ErrorMessage = "Необходимо выбрать бренд")]
        
        public int BrandId { get; set; }
    }
}
