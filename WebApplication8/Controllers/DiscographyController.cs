using Microsoft.AspNetCore.Mvc;

namespace WebApplication8.Controllers
{
    public class DiscographyController : Controller
    {
        public IActionResult Index()
        {
            return View("~/Views/Home/Discography.cshtml");
        }
    }
}
