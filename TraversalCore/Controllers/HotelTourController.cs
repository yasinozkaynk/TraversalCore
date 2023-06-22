using Business.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCore.Controllers
{
    [AllowAnonymous]
    public class HotelTourController : Controller
    {
        IHotelTourService _hotelTourService;

        public HotelTourController(IHotelTourService hotelTourService)
        {
            _hotelTourService = hotelTourService;
        }

        public IActionResult Index(int id)
        {
            var result = _hotelTourService.GetAllById(id);
            return View(result);
        }
        [HttpGet]
        public IActionResult HotelTourDetail(int id)
        {
            ViewBag.i = id;
            var result = _hotelTourService.GetById(id);
            return View(result);
        }
    }
}
