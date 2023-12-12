using Core.Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TraversalCore.Areas.MemberArea.Models;
using TraversalCore.Models;

namespace TraversalCore.ViewComponets.UserNavbar
{
    [AllowAnonymous]
    public class _UserNavigation : ViewComponent
    {
        private readonly UserManager<AppUser> _userManager;

        public _UserNavigation(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        [HttpGet]
        public ViewViewComponentResult Invoke()
        {
            UserDetailsViewModel model = new UserDetailsViewModel()
            {
                UserName = HttpContext.User.Identity.Name,
           
            };
            return View(model);

        }

    }
}
