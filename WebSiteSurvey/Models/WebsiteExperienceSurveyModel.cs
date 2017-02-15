using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

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
        public short ExperienceRating { get; set; }
        public string Suggestion { get; set; }
        public string Referrer { get; }
    }
}