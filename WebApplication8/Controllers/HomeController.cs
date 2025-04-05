using Microsoft.AspNetCore.Mvc;

namespace WebApplication8.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(); // Loads Views/Home/Index.cshtml
        }

        public IActionResult Landing()
        {
            return View(); // Loads Views/Home/Landing.cshtml
        }

        public IActionResult Privacy()
        {
            return View(); // Loads Views/Home/Privacy.cshtml


        }

        public IActionResult Game()
        {
            return View(); // Loads Views/Home/Privacy.cshtml


        }
    }
}
