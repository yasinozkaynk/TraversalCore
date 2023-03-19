using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCore.UI.Controllers
{
    public class Deafault : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
