using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCore.ViewComponets.TrendCategory
{
    public class _TrendCultureTourList : ViewComponent
    {

        public _TrendCultureTourList()
        {
        }

        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
