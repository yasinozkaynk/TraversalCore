using Business.Abstract;
using Core.Entities.Concrete;
using Entity.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TraversalCore.Areas.MemberArea.Models;
using TraversalCore.Models;
using TraversalCore.Services;

namespace TraversalCore.Areas.MemberArea.Controllers
{
    [Area("MemberArea")]
    [Route("MemberArea/[controller]/[action]")]
    public class ReservationController : Controller
    {
        IHolidayTourReservationService _reservationService;
        ICartService _cartService;
        IUserCrediCartService _userCrediCartService;
        private IHolidayTourService _holidayService;
        private ICartSessionService _cartSessionService;

        private readonly UserManager<AppUser> _userManager;

        public ReservationController(IHolidayTourReservationService reservationService, UserManager<AppUser> userManager, ICartService cartService, ICartSessionService cartSessionService = null, IHolidayTourService holidayService = null, IUserCrediCartService userCrediCartService = null)
        {
            _reservationService = reservationService;
            _userManager = userManager;
            _cartService = cartService;
            _cartSessionService = cartSessionService;
            _holidayService = holidayService;
            _userCrediCartService = userCrediCartService;
        }



        public IActionResult Index()
        {
            var values = _userManager.GetUserAsync(HttpContext.User).Result;
            var model = new ReservationViewModel
            {
                AppUserId = values.Id,
                Name = values.Name,
                Surname = values.SurName,
                Cart = _cartSessionService.GetCart(),
                UserCrediCart = _userCrediCartService.GetById(values.Id),

            };


            if (model.UserCrediCart == null || model.Cart.Total <= 0)
            {
                TempData["error"] = "Lütfen Bir Kart Ekleyin !";
                return RedirectToAction("Index", "UserCrediCart");
            }


            return View(model);
        }

        [HttpPost]
        public IActionResult AddReservation(HolidayTourReservation holidayTourReservation)
        {
            _reservationService.Add(holidayTourReservation);
            return RedirectToAction("SuccessReservation");
        }

        public IActionResult SuccessReservation()
        {
            return View();
        }

        public IActionResult ReservationList()
        {
            var values = _userManager.GetUserAsync(HttpContext.User).Result;
            var result = new ReservationListModel
            {
                holidayTourReservations = _reservationService.GetAllById(values.Id),
                HolidayTours = _holidayService.GetAll(),
            };
            return View(result);
        }

    }
}
