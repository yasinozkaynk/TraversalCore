using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCore.Controllers
{
    public class OferController : Controller
    {
        IOferService _oferService;

        public OferController(IOferService oferService)
        {
            _oferService = oferService;
        }

        public IActionResult Index()
        {
            var result = _oferService.GetAll();
            return View(result);
        }
    }
}
