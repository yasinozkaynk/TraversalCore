using Core.Entities.Concrete;
using DataAccess.Concrete.EntityFremawork.Context;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TraversalCore.Models;
using TraversalCore.Services;

namespace TraversalCore.UI.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly IEmailService _emailService;
        public LoginController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, IEmailService emailService)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _emailService = emailService;
        }


        public IActionResult Index()
        {
            return View();
        }
    
        [HttpGet]
        public IActionResult SingUp()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SingUp(UserRegisterViewModel p )
        {
            AppUser appUser = new AppUser()
            {
                Name = p.Name,
                SurName = p.Surname,
                Email = p.Mail,
                UserName = p.UserName,
            };
            if (p.Password==p.ConfirmPassword)
            {
                var result = await _userManager.CreateAsync(appUser,p.Password);
                if (result.Succeeded)
                {
                    return RedirectToAction("SingIn");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            }
           return View();
        }
        [HttpGet]
        public IActionResult SingIn()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> SingIn(UserSignInViewModel p)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(p.username, p.password, false, true);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Profile", new { area = "MemberArea" });
                }
                else
                {
                    return RedirectToAction("SignIn", "Login");
                }
            }
            return View();
        }
        public IActionResult LogOff()
        {
            _signInManager.SignOutAsync().Wait();
            return RedirectToAction("SingIn");
          
        }

        [HttpGet]
        public IActionResult ForgetPassword()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ForgetPassword(ForgetPsswordViewModel request)
        {
            var hasUser = await _userManager.FindByEmailAsync(request.Email);
            if (hasUser==null)
            {
                ModelState.AddModelError(String.Empty, "Bu email adresine sahip kullanıcı bulunamadı");
                return View();
            }
            string passwordResetToken =await _userManager.GeneratePasswordResetTokenAsync(hasUser);
            var passwordResetLink = Url.Action("ResetPassword", "Login",new {userId=hasUser.Id, Token=passwordResetToken},HttpContext.Request.Scheme);

            await _emailService.SendResetPasswordEmail(passwordResetLink,hasUser.Email);

            ViewBag.SuccesMessage = "Şifre yenileme linki, eposta adresinize gönderilmiştir.";
            return RedirectToAction(nameof(ForgetPassword));
        }
        [HttpGet]
        public  IActionResult ResetPassword(string userId,string token)
        {
            TempData["userId"] = userId;
            TempData["token"] = token;
          
            return View();
        } 

        [HttpPost]
        public async Task<IActionResult> ResetPassword(ResetPasswordViewModel request)
        {
            var userId = TempData["userId"].ToString();
            var token = TempData["token"].ToString();

            if (userId==null || token==null)
            {
                throw new Exception("Bir hata meydana geldi");
            }

            var hasUser = await _userManager.FindByIdAsync( userId);

            if (hasUser == null)
            {
                ViewBag.Error( "Kullanıcı Bulunamadı");
                return View();
            }

            IdentityResult result = await _userManager.ResetPasswordAsync(hasUser,token,request.Password);
            if (result.Succeeded)
            {
                ViewBag.SuccesMessage = "Şifreniz başarıyla yenilendi";
            }
            else
            {
                //ModelState.AddModelError(result.Errors.Select(x => x.Description).ToList());
            }
            return View();

        }


    }

}
