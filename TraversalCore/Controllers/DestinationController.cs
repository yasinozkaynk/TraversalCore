using Business.Abstract;
using Entity.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCore.UI.Controllers
{
    [AllowAnonymous]
    public class DestinationController : Controller
    {
        IDestinationService _destinationService;

        public DestinationController(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }

        public IActionResult Index()
        {
            var result = _destinationService.GetList();
            return View(result);
        }
        [HttpGet]
        public IActionResult DestinationDetail(int id)
        {
            ViewBag.i = id;
            var result = _destinationService.GetById(id);
            return View(result);
        }
        [HttpPost]
        public IActionResult DestinationDetail(Destination destination)
        {
            var result = _destinationService.GetList();
            return View(result);
        }
    }
}
