using Microsoft.AspNetCore.Mvc;

namespace MVC.Controllers
{
    public class CarController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
