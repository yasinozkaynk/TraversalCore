using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCore.ViewComponets.Ofer
{
    public class _OferList:ViewComponent
    {
        IOferService _oferService;

        public _OferList(IOferService oferService)
        {
            _oferService = oferService;
        }

        public IViewComponentResult Invoke()
        {
            var result = _oferService.GetAll();
            return View(result);
        }
    }
}
