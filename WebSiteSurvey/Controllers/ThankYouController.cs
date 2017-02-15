using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebSiteSurvey.Models;

namespace WebSiteSurvey.Controllers
{
    public class ThankYouController : Controller
    {
        // GET: ThankYou
        public ActionResult Index(WebsiteExperienceSurveyModel model)
        {
            return View(model);
        }
    }
}