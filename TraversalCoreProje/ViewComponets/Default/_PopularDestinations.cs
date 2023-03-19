using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCore.UI.ViewComponets.Default
{
    public class _PopularDestinations : ViewComponent
    {
        private IDestinationService _destinationService;

        public _PopularDestinations(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }

        public IViewComponentResult Invoke()
        {
            var result=_destinationService.GetList();
           return View(result);
        }
    }
}
