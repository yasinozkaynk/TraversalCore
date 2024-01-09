using Entity.Concrete;
using Entity.DTOs.HolidayTourDetailDTOs;
using System.Collections.Generic;

namespace TraversalCore.Models
{
    public class HolidayTourDetailViewModel
    {
        public HolidayTour HolidayTour { get; set; }
        public HolidayTourDetail HolidayTourDetail  { get; set; }
        public HolidayTourCardDTOs HolidayTourCardDTOs { get; set; }
        public Cart Cart { get; set; }

    }
}
