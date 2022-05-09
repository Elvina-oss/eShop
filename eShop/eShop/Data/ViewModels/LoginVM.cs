using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eShop.Data.ViewModels
{
    public class LoginVM
    {
        [Display(Name="Электронная почта")]
        [Required(ErrorMessage ="Необходимо ввести электронную почту")]
        public string EmailAdress { get; set; }
        [Display(Name = "Пароль")]
        [Required(ErrorMessage = "Необходимо ввести пароль")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
