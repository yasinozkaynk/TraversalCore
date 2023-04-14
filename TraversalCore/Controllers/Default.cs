using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
