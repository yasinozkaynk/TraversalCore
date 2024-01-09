using Business.Abstract;
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
using TraversalCore.OptionsModels;
using TraversalCore.Services;

namespace TraversalCore.UI.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly IEmailService _emailService;
        private readonly IAppUserService _appUserService;
        public LoginController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager, IEmailService emailService, IAppUserService appUserService = null)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _emailService = emailService;
            _appUserService = appUserService;
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
                ImageUrl = p.ImageUrl,
                Email = p.Mail,
                UserName = p.UserName,
                PhoneNumber=p.Phonenumber,
            };
            if (p.Password == null) { TempData["error"] = " şifre kısmı poş geçilemez !"; return View(); }

            if (p.Password==p.ConfirmPassword)
            {
                var result = await _userManager.CreateAsync(appUser,p.Password);
                
                if (result.Succeeded)
                {
                    return RedirectToAction("SingIn");
                }
                else
                {
                    TempData["error"] = "Girdiğiniz şifreler uyuşmuyor !";
                    return View();
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
                    TempData["success"] = "Giriş Başarılı";
                    return RedirectToAction("Index", "Profile", new { area = "MemberArea" });
                }
                else
                {
                    TempData["error"] = "Kullanıcı adı veya şifre hatalı";
                    return View();
                }
            }
            return View();
        }
        public IActionResult LogOff()
        {
            if (ModelState.IsValid)
            {
                _signInManager.SignOutAsync().Wait();
                TempData["success"] = "Çıkış Yapıldı";
                return RedirectToAction("SingIn");
            }
            return RedirectToAction("SingIn");
        }

        [HttpGet]
        public IActionResult ForgetPassword()
        {
            return View();
        }
        [HttpGet]
        public IActionResult DeleteUser(int id)
        {
            var values = _appUserService.GetById(id);
            _appUserService.Delete(values);
            return RedirectToAction("SingIn");
        }

        [HttpPost]
        public async Task<IActionResult> ForgetPassword(ForgetPsswordViewModel request)
        {
            if (request.Email == null) { TempData["error"] = " Lütfen email adresinizi giriniz !"; return View(); }

            var hasUser = await _userManager.FindByEmailAsync(request.Email);
            if (hasUser==null)
            {
                TempData["error"]=("Bu email adresine sahip kullanıcı bulunamadı");
                return View();
            }

            string passwordResetToken =await _userManager.GeneratePasswordResetTokenAsync(hasUser);
            var passwordResetLink = Url.Action("ResetPassword", "Login",new {userId=hasUser.Id, Token=passwordResetToken},HttpContext.Request.Scheme);

            await _emailService.SendResetPasswordEmail(passwordResetLink,hasUser.Email);

            TempData["success"] = "Şifre yenileme linki, eposta adresinize gönderilmiştir.";
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
                TempData["error"] = "Kullanıcı Bulunamadı";
                return View();
            }

            IdentityResult result = await _userManager.ResetPasswordAsync(hasUser,token,request.Password);
            if (result.Succeeded)
            {
                TempData["success"] = "Şifreniz başarıyla yenilendi";
            }
            else
            {
                //ModelState.AddModelError(result.Errors.Select(x => x.Description).ToList());
            }
            return View();

        }


    }

}
