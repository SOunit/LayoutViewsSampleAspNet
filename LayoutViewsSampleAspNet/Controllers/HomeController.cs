using System.Web.Mvc;

namespace LayoutViewsSampleAspNet.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult Profile()
        {
            return View();
        }
    }
}