using Business.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TraversalCore.Models;

namespace TraversalCore.ViewComponets.Category
{
    public class _CategoryList:ViewComponent
    {
        ICategoryService _categoryService;
        ISubhadingService _subhadingService;
        ISubcategoryService _subcategoryService;
        public _CategoryList(ICategoryService categoryService, ISubhadingService subhadingService, ISubcategoryService subcategoryService)
        {
            _categoryService = categoryService;
            _subhadingService = subhadingService;
            _subcategoryService = subcategoryService;
        }

        public IViewComponentResult Invoke()
        {
            var result = new CategoryViewModel
            {
               Category=_categoryService.CategoriList(),
               Subheading=_subhadingService.GetAll(),
               Subcategory=_subcategoryService.GetAll(),
            };
            return View(result);
        }
    }
}
