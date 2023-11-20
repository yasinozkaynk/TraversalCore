using Core.Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TraversalCore.Areas.MemberArea.Models;

namespace TraversalCore.UI.Controllers
{
    [AllowAnonymous]
    public class Default : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        

    }
}
