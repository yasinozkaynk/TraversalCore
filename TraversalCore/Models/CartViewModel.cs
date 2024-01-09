using Entity.Concrete;
using System.Collections.Generic;
using System.Linq;
using TraversalCore.Controllers;

namespace TraversalCore.Models
{
    public class CartViewModel
    {
        public List<CartLineViewModel> Lines { get; set; }

        public CartViewModel()
        {
              Lines=new List<CartLineViewModel>();  
        }
        public void AddItem(HolidayTour holidayTour)
        {
            CartLineViewModel? line = Lines.Where(x => x.HoildayTour.Id == holidayTour.Id).FirstOrDefault();
            if (line is null)
            {
                Lines.Add(new CartLineViewModel()
                {
                   HoildayTour = holidayTour,
                });
            }
             }
        public void RemoveLine(HolidayTour holidayTour)
        {
            Lines.RemoveAll(x => x.HoildayTour.Id == holidayTour.Id);
        }

        public void ComputeTotalValu() => Lines.Sum(x => x.HoildayTour.Price * x.Quantity);
        public void Clear()=> Lines.Clear();

    }
}
