using Business.Abstract;
using Core.Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCore.Admin.Controllers
{
    [AllowAnonymous]
    public class UserController : Controller
    {
        IAppUserService _appUserService;
        IReservationService _reservationService;

        public UserController(IAppUserService appUserService, IReservationService reservationService)
        {
            _appUserService = appUserService;
            _reservationService = reservationService;
        }

        public IActionResult Index()
        {
            var values = _appUserService.GetAll();
            return View(values);
        }
        public IActionResult Delete(int id)
        {
            var values = _appUserService.GetById(id);
            _appUserService.Delete(values);
            return RedirectToAction("Index");
        }
        public IActionResult CommentUser()
        {
            _appUserService.GetAll();
            return View();
        }
        public IActionResult ReservationUser(int id)
        {
            var values = _reservationService.GetListWithReservationByAccepted(id);
            return View(values);
        }
    }
}
