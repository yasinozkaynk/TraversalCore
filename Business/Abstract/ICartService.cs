using Entity.Concrete;
using Entity.DTOs.HolidayTourDetailDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICartService
    {
        void AddToCart(Cart cart, HolidayTourCardDTOs holidayTour);
        void RemoveToCart(Cart cart,int id);
        List<CartLine> List(Cart cart);
    }
}
