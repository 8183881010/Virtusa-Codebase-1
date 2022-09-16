using Microsoft.AspNetCore.Mvc;

namespace HandsOnBootstrap.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
