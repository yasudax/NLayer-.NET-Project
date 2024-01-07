using Microsoft.AspNetCore.Mvc;

namespace CvPortf.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
