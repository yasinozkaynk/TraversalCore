using Business.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCore.Controllers
{
    [AllowAnonymous]
    public class HolidayTourController : Controller
    {
        IHoildayTourService _hoildayTourService;

        public HolidayTourController(IHoildayTourService hoildayTourService)
        {
            _hoildayTourService = hoildayTourService;
        }
        public IActionResult Index(int id)
        {
            var result = _hoildayTourService.GetAllById(id);
            return View(result);
        }
       
    }
}
