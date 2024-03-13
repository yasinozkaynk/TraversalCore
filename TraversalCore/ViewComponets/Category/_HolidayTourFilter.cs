using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCore.ViewComponets.Category
{
    public class _HolidayTourFilter : ViewComponent
    {
        IHolidayTourService _holidayTourService;

        public _HolidayTourFilter(IHolidayTourService holidayTourFilter)
        {
            _holidayTourService = holidayTourFilter;
        }

        [HttpGet]
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
