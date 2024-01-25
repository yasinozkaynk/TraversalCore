using Entity.Concrete;
using System.Collections.Generic;

namespace TraversalCore.Areas.MemberArea.Models
{
    public class ReservationListModel
    {
        public int UserId { get; set; }
        public List<HolidayTourReservation> holidayTourReservations { get; set; }
        public List<HolidayTour> HolidayTours { get; set; }
    }
}
