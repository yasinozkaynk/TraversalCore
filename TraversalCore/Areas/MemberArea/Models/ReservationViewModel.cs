using Entity.Concrete;
using System;

namespace TraversalCore.Areas.MemberArea.Models
{
    public class ReservationViewModel
    {
        public int AppUserId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int PersonCount { get; set; }
        public int HolidayTourId { get; set; }
        public DateTime ReservastionDate { get; set; }
        public bool Status { get; set; }
        public Cart Cart  { get; set; }
        public UserCrediCart UserCrediCart { get; set; }
        public CartLine CartLine   { get; set; }
        public HolidayTour HolidayTour { get; set; }
        public HolidayTourReservation HolidayTourReservation { get; set; }

    }
}
