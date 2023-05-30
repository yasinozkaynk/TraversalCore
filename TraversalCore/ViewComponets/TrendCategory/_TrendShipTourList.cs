using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCore.ViewComponets.TrendCategory
{
    public class _TrendShipTourList : ViewComponent
    {
        ISubcategoryService _subCategoryService;

        public _TrendShipTourList(ISubcategoryService subCategoryService)
        {
            _subCategoryService = subCategoryService;
        }

        public IViewComponentResult Invoke()
        {
            var result = _subCategoryService.GetAll();
            return View(result);
        }
    }

}
