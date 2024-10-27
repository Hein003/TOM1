using Microsoft.AspNetCore.Mvc;

namespace Tom.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
