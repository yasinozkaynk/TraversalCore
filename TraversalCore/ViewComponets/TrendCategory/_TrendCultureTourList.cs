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
        IDestinationService _destinationService;

        public _TrendCultureTourList(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }

        public IViewComponentResult Invoke()
        {
            var result = _destinationService.GetList();
            return View(result);
        }
    }
}
