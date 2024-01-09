using Business.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TraversalCore.Models;
using TraversalCore.Services;

namespace TraversalCore.Controllers
{
    [AllowAnonymous]
    public class CartController : Controller
    {

        private ICartSessionService _cartSessionService;
        private ICartService _cartService;
        private IHolidayTourService _holidayTourService;

        public CartController(ICartSessionService cartSessionService, ICartService cartService, IHolidayTourService holidayTourService)
        {
            _cartSessionService = cartSessionService;
            _cartService = cartService;
            _holidayTourService = holidayTourService;
        }

        public IActionResult Index()
        {
            var model = new CartSummaryViewModel
            {
                Cart = _cartSessionService.GetCart()
            };
            return View(model);
        }
        public IActionResult AddToCart(int id)
        {
            var productToBeAdded=_holidayTourService.GetByCardId(id);
            var cart = _cartSessionService.GetCart();
            _cartService.AddToCart(cart,productToBeAdded);
            _cartSessionService.SetCart(cart);
            return RedirectToAction("Index","Cart");
        }
        public IActionResult RemoveToCart(int id)
        {
            var cart = _cartSessionService.GetCart();
            _cartService.RemoveToCart(cart,id);
            _cartSessionService.SetCart(cart);
            return RedirectToAction("Index", "Cart");
        }
    }
}
