using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCore.Areas.MemberArea.Controllers
{
[Area("MemberArea")]
[AllowAnonymous]
public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
