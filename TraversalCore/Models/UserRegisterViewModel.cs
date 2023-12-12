using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCore.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage = "Bu alan boş geçilemez")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Bu alan boş geçilemez")]

        public string Surname { get; set; }
        [Required(ErrorMessage = "Bu alan boş geçilemez")]

        public string UserName { get; set; }
        [Required(ErrorMessage = "Bu alan boş geçilemez")]

        public string Phonenumber { get; set; }

        [Required(ErrorMessage = "Bu alan boş geçilemez")]

        public string ImageUrl { get; set; }
        [Required(ErrorMessage = "Bu alan boş geçilemez")]

        public string Gender { get; set; }
        [Required(ErrorMessage = "Bu alan boş geçilemez")]

        public string Mail { get; set; }
        [Required(ErrorMessage = "Bu alan boş geçilemez")]

        public string Password { get; set; }

        [Required(ErrorMessage = "Bu alan boş geçilemez")]
        [Compare("Password", ErrorMessage = "Şifreler Uyuşmuyor")]
        public string ConfirmPassword { get; set; }
    }
}
