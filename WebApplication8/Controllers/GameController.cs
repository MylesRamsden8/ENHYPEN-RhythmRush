using Microsoft.AspNetCore.Mvc;

public class RhythmRushController : Controller
{
    public IActionResult Index()
    {
        return View("~/Views/Home/Game.cshtml");
    }
}
