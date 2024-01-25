using Business.Abstract;
using Core.Entities.Concrete;
using Entity.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using TraversalCore.Areas.MemberArea.Models;
using TraversalCore.Models;

namespace TraversalCore.Areas.MemberArea.Controllers
{
    [Area("MemberArea")]
    [Route("MemberArea/[controller]/[action]")]

    public class UserCrediCartController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly IUserCrediCartService _userCrediCartService;
        public UserCrediCartController(UserManager<AppUser> userManager, IUserCrediCartService userCrediCartService)
        {
            _userManager = userManager;
            _userCrediCartService = userCrediCartService;
        }
        public IActionResult Index()
        {
            var values = _userManager.GetUserAsync(HttpContext.User).Result;

            UserCrediCartViewModel model = new UserCrediCartViewModel()
            {
                Id = values.Id,
                UserName = HttpContext.User.Identity.Name,
                UserId = values.Id,
                Surname = values.SurName,
                Name = values.Name,
                Imageurl = values.ImageUrl,
                UserCrediCarts = _userCrediCartService.GetAll()
            };
            return View(model);
        }

        public IActionResult RemoveToCrediCart(int id)
        {
            var result = _userCrediCartService.GetById(id);
            _userCrediCartService.Delete(result);
            return RedirectToAction("Index","UserCrediCart");
        }

        [HttpPost]
        public IActionResult AddToCrediCart(UserCrediCart userCrediCart)
        {
            _userCrediCartService.Add(userCrediCart);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateCrediCart(  )
        {
            return View();
        }

        [HttpPost]
        public IActionResult UpdateCrediCart(int id)
        {
            var result = _userCrediCartService.GetByElementId(id);
            _userCrediCartService.Update(result);
            return RedirectToAction("Index");
        }
    }
}
