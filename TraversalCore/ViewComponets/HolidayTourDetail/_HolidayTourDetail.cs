using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using TraversalCore.Models;

namespace TraversalCore.ViewComponets.HolidayTourDetail
{
    public class _HolidayTourDetail:ViewComponent
    {
        IHolidayTourDetailService _holidayTourDetailService;

        public _HolidayTourDetail(IHolidayTourDetailService holidayTourDetailService)
        {
            _holidayTourDetailService = holidayTourDetailService;
        }
        public IViewComponentResult Invoke(int id)
        {
            var result = new HolidayTourDetailViewModel
            {
                HolidayTourCardDTOs = _holidayTourDetailService.GetAlById(id)
            };

            return View(result);
        }
    }
}
