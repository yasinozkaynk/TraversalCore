using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCore.UI.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult SingUp()
        {
            return View();
        }
        //[HttpPost]
        //public IActionResult SingUp()
        //{
        //    return View();
        //}
        [HttpGet]
        public IActionResult SingIn()
        {
            return View();
        }
        //[HttpPost]
        //public IActionResult SingIn()
        //{
        //    return View();
        //}
    }
}
