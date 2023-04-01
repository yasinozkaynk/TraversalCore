using Business.Abstract;
using Business.ValidationRules;
using Entity.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCore.Admin.Controllers
{
    [AllowAnonymous]
    public class GuideController : Controller
    {
        IGuideService _guideService;

        public GuideController(IGuideService guideService)
        {
            _guideService = guideService;
        }

        public IActionResult Index()
        {
            var result = _guideService.GetAll();
            return View(result);
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Guide guide)
        {
            _guideService.Add(guide);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            var values = _guideService.GetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult Update(Guide guide)
        {
            _guideService.Update(guide);
            return RedirectToAction("Index");
        }


        public IActionResult ChangeToTrue(int id)
        {
            _guideService.ChangeToTrueByGuide(id);
            return RedirectToAction("Index", "Guide", new { area = "Admin" });
        }

        public IActionResult ChangeToFalse(int id)
        {
            _guideService.ChangeToFalseByGuide(id);
            return RedirectToAction("Index", "Guide", new { area = "Admin" });
        }
    }
}
