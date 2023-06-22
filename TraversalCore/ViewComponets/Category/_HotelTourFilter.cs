using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCore.ViewComponets.Category
{
    public class _HotelTourFilter : ViewComponent
    {
        IHotelTourService _hotelTourService;

        public _HotelTourFilter(IHotelTourService hotelTourService)
        {
            _hotelTourService = hotelTourService;
        }

        [HttpGet]
        public IViewComponentResult Invoke(string hotelName)
        {
            if (hotelName != null)
            {
                var result = _hotelTourService.GetHotelNameFilter(hotelName);
                ViewBag.HotelName = hotelName;
                return View(result);
            }
            return View();
        }
    }
}
