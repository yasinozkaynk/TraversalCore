using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCore.UI.ViewComponets.Default
{
    public class _Testimonial:ViewComponent
    {
        ITestimonialService _testimonialService;

        public _Testimonial(ITestimonialService testimonialService)
        {
            _testimonialService = testimonialService;
        }

        public IViewComponentResult Invoke()
        {
            var result = _testimonialService.GetList();
            return View(result);
        }
    }
}
