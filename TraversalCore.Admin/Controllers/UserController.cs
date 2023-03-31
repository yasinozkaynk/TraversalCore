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

        public UserController(IAppUserService appUserService)
        {
            _appUserService = appUserService;
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
        [HttpGet]
        public IActionResult Update(int id)
        {
            var values = _appUserService.GetById(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult Update(AppUser appUser)
        {
            _appUserService.Update(appUser);
            return RedirectToAction("Index");
        }

        public IActionResult CommentUser()
        {
            _appUserService.GetAll();
            return View();
        }

    }
}
