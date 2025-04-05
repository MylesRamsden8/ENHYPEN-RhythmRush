using Microsoft.AspNetCore.Mvc;

namespace WebApplication8.Controllers
{
    public class MembersController : Controller
    {
        public IActionResult Index()
        {
            return View("~/Views/Home/Members.cshtml");
        }
    }
}
