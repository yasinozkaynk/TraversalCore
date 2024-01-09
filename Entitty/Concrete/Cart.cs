using System.Collections.Generic;
using System.Linq;

namespace Entity.Concrete
{
    public class Cart
    {
        public Cart()
        {
            CartLines = new List<CartLine>();
        }
        public List<CartLine> CartLines { get; set; }
        public CartLine CartLine { get; set; }

        public decimal Total
        {
              get { return CartLines.Sum(c=>c.holidayTourCardDTOs.TourPrice * c.Quantity); }
        }
    }
}
