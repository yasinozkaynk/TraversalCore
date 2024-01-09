using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCore.ViewComponets.HotelDetail
{
    public class _MostPreferredHotels:ViewComponent
    {
        IHotelTourService _hotelTourService;

        public _MostPreferredHotels(IHotelTourService hotelTourService)
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
