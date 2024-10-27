using Microsoft.AspNetCore.Mvc;

namespace Tom.Controllers
{
    public class BirthdayController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
