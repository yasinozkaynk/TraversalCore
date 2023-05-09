using Business.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCore.Areas.MemberArea.Controllers
{
    [Area("MemberArea")]
    public class DestinationController : Controller
    {
        IDestinationService _destinationService;

        public DestinationController(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }
        public IActionResult Index1()
        {
            var result = _destinationService.GetList();
            return View(result);
        }
    }
}
