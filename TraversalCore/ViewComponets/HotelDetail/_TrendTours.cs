using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCore.ViewComponets.HotelDetail
{
    public class _TrendTours : ViewComponent
    {
        IHolidayTourService _holidayTourService;

        public _TrendTours(IHolidayTourService holidayTourService)
        {
            _holidayTourService = holidayTourService;
        }

        public IViewComponentResult Invoke()
        {
            var result = _holidayTourService.GetAll();
            return View(result);
        }
    }
}
