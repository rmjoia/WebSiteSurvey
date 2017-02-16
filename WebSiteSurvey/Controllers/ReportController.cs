using System.Linq;
using System.Web.Mvc;
using WebSiteSurvey.Data;
using WebSiteSurvey.Models;

namespace WebSiteSurvey.Controllers
{
    public class ReportController : Controller
    {
        // GET: Report
        public ActionResult Index()
        {
            ReportModel reportData;
            using (var repository = new WebSiteSurveyRepository())
            {
                var surveyData = repository.GetAll();

                reportData = new ReportModel(
                    surveyData.Select(s=> (int)s.ExperienceRating), 
                    surveyData.Select(s => s.Age),
                    surveyData.Select(s => s.Gender), 
                    surveyData.Select(s => s.Country));
            }

            return View(reportData);
        }
    }
}