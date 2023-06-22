using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCore.ViewComponets.HotelDetail
{
    public class _HotelTourDetail : ViewComponent
    {
        IHotelTourDetailService _hotelTourDetailService;

        public _HotelTourDetail(IHotelTourDetailService hotelTourDetailService)
        {
            _hotelTourDetailService = hotelTourDetailService;
        }

        public IViewComponentResult Invoke(int id)
        {
            var result = _hotelTourDetailService.GetHotelDetail(id);
            return View(result);
        }
    }
}
