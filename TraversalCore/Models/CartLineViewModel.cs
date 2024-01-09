using Entity.Concrete;
using System.Security.Permissions;

namespace TraversalCore.Models
{
    public class CartLineViewModel
    {
        public int CartLineId { get; set; }
        public HolidayTour HoildayTour { get; set; }
        public int Quantity { get; set; }
    }
}
