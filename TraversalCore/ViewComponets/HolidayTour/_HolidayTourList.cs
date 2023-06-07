using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCore.ViewComponets.HolidayTour
{
    public class _HolidayTourList : ViewComponent
    {
        IHoildayTourService _hoildayTourService;

        public _HolidayTourList(IHoildayTourService hoildayTourService)
        {
            _hoildayTourService = hoildayTourService;
        }

        public IViewComponentResult Invoke(int id)
        {
            var result = _hoildayTourService.GetAllById(id);
            return View(result);
        }
    }
}
