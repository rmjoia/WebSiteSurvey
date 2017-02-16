using System;
using System.ComponentModel.DataAnnotations;

namespace WebSiteSurvey.Data.Models
{
    public class WebSiteSurvey
    {
        public WebSiteSurvey()
        {
            ResponseId = Guid.NewGuid();
            SubmissionDate = DateTime.UtcNow;
        }

        [Key]
        public Guid ResponseId { get; private set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Country { get; set; }
        public short ExperienceRating { get; set; }
        public string Suggestion { get; set; }
        public string Referrer { get; set; }
        public DateTime SubmissionDate { get; private set; }
    }
}
