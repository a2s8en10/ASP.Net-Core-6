using Microsoft.AspNetCore.Mvc;

namespace RoutingWithoutMVC.Controller
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
