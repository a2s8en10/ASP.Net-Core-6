using Microsoft.AspNetCore.Mvc;

namespace Convention_Based_Routing_WithOut__MVC.Controller
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
