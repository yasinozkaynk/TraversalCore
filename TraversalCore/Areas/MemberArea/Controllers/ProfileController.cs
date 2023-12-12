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
                Phonenumber = values.PhoneNumber,
                Name = values.Name,
                Surname = values.SurName,
                ImageUrl = values.ImageUrl,
                Id = values.Id,
                Mail = values.Email
            };
            return View(model);
        }

        [HttpGet]
        public IActionResult Update()
        {
            var values = _userManager.FindByNameAsync(User.Identity.Name).Result;
            UserEditViewModel model = new UserEditViewModel()
            {
                userName = HttpContext.User.Identity.Name,
                name = values.Name,
                surname = values.SurName,
                phonenumber = values.PhoneNumber,
                imageurl = values.ImageUrl,
                Id = values.Id,
                mail = values.Email,
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Update(UserEditViewModel p)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);

            //var resource = Directory.GetCurrentDirectory();
            //var extension = Path.GetExtension(p.imageurl.FileName);
            //var imagename = Guid.NewGuid() + extension;
            //var savelocation = resource + "/wwwroot/userimages/" + imagename;
            //var stream = new FileStream(savelocation, FileMode.Create);
            //await p.Image.CopyToAsync(stream);
            //user.ImageUrl = imagename;
            user.UserName = HttpContext.User.Identity.Name;
            user.Name = p.name;
            user.SurName = p.surname;
            user.Email = p.mail;
            user.PhoneNumber = p.phonenumber;
            var result = await _userManager.UpdateAsync(user);
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Profile");
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> UpdatePassword(UserEditViewModel p)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, p.updatePassword.password);

            if (p.updatePassword.password == p.updatePassword.confirmpassword)
            {
                var result = await _userManager.UpdateAsync(user);
                if (result.Succeeded)
                {
                    TempData["success"] = "Şifreniz başarıyla yenilendi";
                    return RedirectToAction("Update", "Profile");
                }
            }
            else
            {
                TempData["error"] = "Girdiğiniz şifre uyuşmuyor";
                return RedirectToAction("Update", "Profile");
            }
            return View();
        }
    }
}
