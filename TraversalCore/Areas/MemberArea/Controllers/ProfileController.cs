using Core.Entities.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using TraversalCore.Areas.MemberArea.Models;
using TraversalCore.Models;

namespace TraversalCore.Areas.MemberArea.Controllers
{
    [Area("MemberArea")]
    [Route("MemberArea/[controller]/[action]")]
    public class ProfileController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public ProfileController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var values = _userManager.GetUserAsync(HttpContext.User).Result;

            UserDetailsViewModel model = new UserDetailsViewModel()
            {
                UserName = HttpContext.User.Identity.Name,
                Phonenumber=values.PhoneNumber,
                Name=values.Name,
                Surname=values.SurName,
                ImageUrl=values.ImageUrl,
                Id=values.Id,
                Mail=values.Email
            };
            return View(model);
        }

        [HttpGet]
        public IActionResult Update()
        {
            var values = _userManager.GetUserAsync(HttpContext.User).Result;
            UserDetailsViewModel model = new UserDetailsViewModel()
            {
                UserName = HttpContext.User.Identity.Name,
                Phonenumber = values.PhoneNumber,
                ImageUrl = values.ImageUrl,
                Id = values.Id,
                Mail = values.Email
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Update(UserEditViewModel p)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            if (p.Image != null)
            {
                var resource = Directory.GetCurrentDirectory();
                var extension = Path.GetExtension(p.Image.FileName);
                var imagename = Guid.NewGuid() + extension;
                var savelocation = resource + "/wwwroot/userimages/" + imagename;
                var stream = new FileStream(savelocation, FileMode.Create);
                await p.Image.CopyToAsync(stream);
                user.ImageUrl = imagename;
            }
            user.Name = p.name;
            user.SurName = p.surname;
            user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, p.password);
            var result = await _userManager.UpdateAsync(user);
            if (result.Succeeded)
            {
                return RedirectToAction("SignIn", "Login");
            }
            return View();
        }
    }
}
