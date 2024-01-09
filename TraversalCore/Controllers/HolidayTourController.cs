using Business.Abstract;
using Entity.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TraversalCore.Models;

namespace TraversalCore.Controllers
{
    [AllowAnonymous]
    public class HolidayTourController : Controller
    {
        IHolidayTourService _hoildayTourService;

        public HolidayTourController(IHolidayTourService hoildayTourService)
        {
            _hoildayTourService = hoildayTourService;
        }
        public IActionResult Index(int id)
        {
            var result = _hoildayTourService.GetAllById(id);
            return View(result);
        }
        public IActionResult HolidayTourDetail(int id)
        {
            ViewBag.Id = id;
            ViewBag.i = HttpContext.User.Identity.Name;
            var result = new HolidayTourDetailViewModel
            {
                HolidayTour = _hoildayTourService.GetById(id)
            };
            return View(result);
        }


    }
}
