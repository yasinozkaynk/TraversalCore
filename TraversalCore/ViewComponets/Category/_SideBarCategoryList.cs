using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TraversalCore.ViewComponets.Category
{
    public class _SideBarCategoryList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
