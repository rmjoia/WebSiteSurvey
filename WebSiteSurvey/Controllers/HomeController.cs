using System;
using System.Web.Mvc;
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
                    repository.Insert(new Data.Models.WebSiteSurvey()
                    {
                        Name = formResult.Name,
                        Age = formResult.Age,
                        Country = formResult.Country,
                        Email = formResult.Email,
                        ExperienceRating = formResult.ExperienceRating,
                        Gender = formResult.Gender,
                        Referrer = formResult.Referrer,
                        Suggestion = formResult.Suggestion
                    });
                }
            }
            catch (Exception)
            {
                return RedirectToAction("Index", "Error");
            }

            return RedirectToAction("Index", "ThankYou", formResult);
        }
    }
}