using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebSiteSurvey.Models
{
    public class WebsiteExperienceSurveyModel
    {
        public WebsiteExperienceSurveyModel(string referrer)
        {
            Referrer = referrer;
        }

        public string Name { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Country { get; set; }

        [Display(Name = "Rate your experience")]
        public short ExperienceRating { get; set; }

        public string Suggestion { get; set; }
        public string Referrer { get; }

        public SelectList Genders { get; set; } = new SelectList(GenderList(), "Value", "Text");

        public SelectList Countries = new SelectList(GetCountries(), "Text", "Value");

        private static IEnumerable<SelectListItem> GenderList()
        {
            return new List<SelectListItem>
            {
                new SelectListItem() {Value = "Male", Text = "Male"},
                new SelectListItem() {Value = "Female", Text = "Female"}
            };
        }

        private static IEnumerable<SelectListItem> GetCountries()
        {
            return CultureInfo.GetCultures(CultureTypes.SpecificCultures)
                .Select(c => new RegionInfo(c.LCID).EnglishName)
                .Distinct()
                .OrderBy(c => c)
                .Select(c => new SelectListItem {Text = c, Value = c});
        }
    }
}