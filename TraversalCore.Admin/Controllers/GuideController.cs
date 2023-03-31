using Business.Abstract;
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
        [Route("AddGuide")]
        [HttpGet]
        public IActionResult AddGuide()
        {
            return View();
        }

        [Route("AddGuide")]
        [HttpPost]
        public IActionResult AddGuide(Guide guide)
        {
            GuideValidator validationRules = new GuideValidator();
            ValidationResult result = validationRules.Validate(guide);
            if (result.IsValid)
            {
                _guideService.Add(guide);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View();
            }
        }
        [Route("EditGuide")]
        [HttpGet]
        public IActionResult EditGuide(int id)
        {
            var values = _guideService.GetById(id);
            return View(values);
        }
        [Route("EditGuide")]
        [HttpPost]
        public IActionResult EditGuide(Guide guide)
        {
            _guideService.Update(guide);
            return RedirectToAction("Index");
        }

        [Route("ChangeToTrue/{id}")]

        public IActionResult ChangeToTrue(int id)
        {
            _guideService.ChangeToTrueByGuide(id);
            return RedirectToAction("Index", "Guide", new { area = "Admin" });
        }
        [Route("ChangeToFalse/{id}")]

        public IActionResult ChangeToFalse(int id)
        {
            _guideService.ChangeToFalseByGuide(id);
            return RedirectToAction("Index", "Guide", new { area = "Admin" });
        }
    }
}
