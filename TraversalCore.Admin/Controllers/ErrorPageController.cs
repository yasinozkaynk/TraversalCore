using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCore.Admin.Controllers
{
    public class ErrorPageController : Controller
    {
        public IActionResult Eror404(int code)
        {
            return View();
        }
    }
}
