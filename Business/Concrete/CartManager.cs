using Business.Abstract;
using Entity.Concrete;
using Entity.DTOs.HolidayTourDetailDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CartManager : ICartService
    {
        public void AddToCart(Cart cart, HolidayTourCardDTOs holidayTour)
        {
            CartLine cartLine = cart.CartLines.FirstOrDefault(x => x.holidayTourCardDTOs.HolidayTourId == holidayTour.Id);
            if (cartLine != null)
            {
                cartLine.Quantity++;
                return;
            }
            cart.CartLines.Add(new CartLine {holidayTourCardDTOs= holidayTour,Quantity=1});
        
        }

        public void RemoveToCart(Cart cart, int id)
        {
            cart.CartLines.Remove(cart.CartLines.FirstOrDefault(x=>x.holidayTourCardDTOs.HolidayTourId==id));
        }

        public List<CartLine> List(Cart cart)
        {
            return cart.CartLines;
        }
    }
}
