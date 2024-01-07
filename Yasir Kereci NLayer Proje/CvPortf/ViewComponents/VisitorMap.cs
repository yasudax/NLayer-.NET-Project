using Microsoft.AspNetCore.Mvc;

namespace CvPortf.ViewComponents
{
    public class VisitorMap : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
