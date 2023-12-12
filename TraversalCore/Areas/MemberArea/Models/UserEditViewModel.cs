using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCore.Areas.MemberArea.Models
{
    public class UserEditViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Bu alan boş geçilemez")]

        public string name { get; set; }
        [Required(ErrorMessage = "Bu alan boş geçilemez")]

        public string surname { get; set; }  
        [Required(ErrorMessage = "Bu alan boş geçilemez")]

        public string userName { get; set; }
        [Required(ErrorMessage = "Bu alan boş geçilemez")]

        public string phonenumber { get; set; }
        [Required(ErrorMessage = "Bu alan boş geçilemez")]
        public string mail { get; set; }
        [Required(ErrorMessage = "Bu alan boş geçilemez")]
        public string imageurl { get; set; }
        [Required(ErrorMessage = "Bu alan boş geçilemez")]
        public IFormFile Image { get; set; }

        public UpdatePassword  updatePassword { get; set; }


    }
}
