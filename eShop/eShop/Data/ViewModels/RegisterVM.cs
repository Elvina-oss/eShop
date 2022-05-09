using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eShop.Data.ViewModels
{
    public class RegisterVM
    {
        [Display(Name = "Фамилия Имя")]
        [Required(ErrorMessage = "Необходимо ввести ваши Фамилию и Имя")]
        public string FullName { get; set; }
        [Display(Name="Электронная почта")]
        [Required(ErrorMessage ="Необходимо ввести электронную почту")]
        public string EmailAdress { get; set; }
        [Display(Name = "Пароль")]
        [Required(ErrorMessage = "Необходимо ввести пароль")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [Display(Name = "Подтвердите пароль")]
        [Required(ErrorMessage = "Необходимо подтвердить пароль")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage ="Пароли не совпадают")]
        public string ConfirmPassword { get; set; }
    }
}

