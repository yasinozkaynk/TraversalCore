﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCore.Models
{
    public class UserDetailsViewModel
    {
        public string UserName { get; set; }
        public string  Name { get; set; }
        public string  Surname { get; set; }
        public string  ImageUrl { get; set; }
        public IFormFile  Image { get; set; }
        public string Mail { get; set; }
        public string Phonenumber { get; set; }
        public int Id { get; set; }
        public string Password { get; set; }
        public string Confirmpassword { get; set; }
    }
}
