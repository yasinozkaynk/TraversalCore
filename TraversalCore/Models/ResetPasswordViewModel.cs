using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCore.Models
{
    public class ResetPasswordViewModel
    {
        [Required(ErrorMessage = "Şifre alanı boş bırakılamaz")]
        [Display(Name = "Yeni Şifre : ")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Şifre alanı boş bırakılamaz")]
        [Compare(nameof(Password),ErrorMessage ="Şifre aynı değildir")]
        [Display(Name = "Yeni Şifre Tekrar : ")]
        public string ConfirmPassword { get; set; }
    }
}
