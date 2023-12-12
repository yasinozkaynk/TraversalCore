using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCore.Areas.MemberArea.Models
{
    public class UpdatePassword
    {
        public string password { get; set; }
        public string confirmpassword { get; set; }
    }
}
