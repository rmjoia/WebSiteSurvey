using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using WebSiteSurvey.Models;

namespace WebSiteSurvey.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var referrer = GetReferrer();

            var newSurvey = new WebsiteExperienceSurveyModel(referrer);
            return View(newSurvey);
        }

        public ActionResult Submit(WebsiteExperienceSurveyModel websiteExperienceSurveyModel)
        {
            return Redirect("http://www.disney.com");
        }

        public ActionResult Clear(WebsiteExperienceSurveyModel websiteExperienceSurveyModel)
        {
            websiteExperienceSurveyModel = new WebsiteExperienceSurveyModel(websiteExperienceSurveyModel.Referrer);
            return View("Index", websiteExperienceSurveyModel);
        }

        public ActionResult SubmitForm(string action)
        {
            throw new NotImplementedException();
        }



        private string GetReferrer()
        {
            var referrer = string.Empty;

            if (Session["referrer"] != null) return referrer;

            referrer = Request.UrlReferrer?.ToString() ?? "unkown";
            Session.Add("referrer", referrer);
            return referrer;
        }

        public ActionResult Edit(WebsiteExperienceSurveyModel model)
        {
            throw new NotImplementedException();
        }
    }
}