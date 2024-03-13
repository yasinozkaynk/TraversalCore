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
    [Route("MemberArea/UserCrediCart")]
    public class UserCrediCartController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly IUserCrediCartService _userCrediCartService;
        public UserCrediCartController(UserManager<AppUser> userManager, IUserCrediCartService userCrediCartService)
        {
            _userManager = userManager;
            _userCrediCartService = userCrediCartService;
        }

        [Route("Index")]
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
        [Route("RemoveToCrediCart/{id}")]
        public IActionResult RemoveToCrediCart(int id)
        {
            var result = _userCrediCartService.GetByElementId(id);
            _userCrediCartService.Delete(result);
            return RedirectToAction("Index");
        }

        [Route("Index")]
        [HttpPost]
        public IActionResult AddToCrediCart(UserCrediCart userCrediCart)
        {
            var values = _userManager.FindByNameAsync(User.Identity.Name).Result;
            userCrediCart.UserId = values.Id;
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
