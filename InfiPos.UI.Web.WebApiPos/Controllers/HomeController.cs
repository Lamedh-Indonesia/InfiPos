using System.Web.Mvc;

namespace InfiPos.UI.Web.WebApiPos.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";
            return View();
        }
    }
}
