using System.Web.Mvc;

namespace WebSiteSurvey.Controllers
{
    public class ThankYouController : Controller
    {
        // GET: ThankYou
        public ActionResult Index()
        {
            ViewBag.Name = TempData["Name"];
            ViewBag.Email = TempData["Email"];

            return View();
        }
    }
}