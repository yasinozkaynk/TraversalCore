using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCore.ViewComponets.HotelDetail
{
    public class _TrendHotels : ViewComponent
    {
        IHotelTourService  _hotelTourService;

        public _TrendHotels(IHotelTourService hotelTourService)
        {
            _hotelTourService = hotelTourService;
        }

        public IViewComponentResult Invoke()
        {
            var result = _hotelTourService.GetAll();
            return View(result);
        }
    }
}
