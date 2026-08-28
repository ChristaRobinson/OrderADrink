using Microsoft.AspNetCore.Mvc;

namespace Bartender.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
