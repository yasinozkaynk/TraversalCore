using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCore.Models
{
    public class ForgetPsswordViewModel
    {
        [Required(ErrorMessage ="Email alanı boş bırakılamaz")]
        [EmailAddress(ErrorMessage ="Email formatı yanlıştır")]
        [Display(Name ="Email : ")]
        public string Email { get; set; }
    }
}
