using Business.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCore.ViewComponets.HotelDetail
{
    public class _MostPreferredTours:ViewComponent
    {
        IHolidayTourService _holidayTourService;

        public _MostPreferredTours(IHolidayTourService holidayTourService)
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
