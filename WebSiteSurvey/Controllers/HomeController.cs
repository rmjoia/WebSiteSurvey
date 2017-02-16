using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using WebSiteSurvey.Data;
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

        private string GetReferrer()
        {
            var referrer = string.Empty;

            if (Session["referrer"] != null) return referrer;

            referrer = Request.UrlReferrer?.ToString() ?? "unkown";
            Session.Add("referrer", referrer);
            return referrer;
        }

        public ActionResult Submit(WebsiteExperienceSurveyModel model)
        {
            var formResult = model;
            formResult.Referrer = Session["referrer"].ToString();

            try
            {
                using (var repository = new WebSiteSurveyRepository())
                {
                    
                }
            }
            catch (Exception)
            {
                
                throw;
            }

            return RedirectToAction("Index", "ThankYou", formResult);
        }
    }
}