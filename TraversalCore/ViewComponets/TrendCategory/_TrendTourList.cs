using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCore.ViewComponets.TrendCategory
{
    public class _TrendTourList:ViewComponent
    {
        ISubcategoryService _subCategoryService;

        public _TrendTourList(ISubcategoryService subCategoryService)
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
