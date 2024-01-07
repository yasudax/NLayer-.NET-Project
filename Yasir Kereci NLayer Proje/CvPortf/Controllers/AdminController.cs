using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CvPortf.Controllers
{
    public class AdminController : Controller
    {
        AboutManager aboutManager = new AboutManager(new EfAboutDal());
        public PartialViewResult PartialSideBar()
        {
            return PartialView();
        }
        public PartialViewResult PartialFooter()
        {
            return PartialView();
        }
        public PartialViewResult PartialNavbar()
        {
            return PartialView();
        }
        public PartialViewResult PartialHead()
        {
            return PartialView();
        }
        public PartialViewResult PartialScript()
        {
            return PartialView();
        }
        public PartialViewResult NavigationPartial()
        {
            return PartialView();
        }
        public PartialViewResult NewSideBar()
        {
            var about = aboutManager.TGetList().FirstOrDefault();
            return PartialView(about);
        }

    }
}
