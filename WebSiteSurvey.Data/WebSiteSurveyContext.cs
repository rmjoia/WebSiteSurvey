using System.Data.Entity;

namespace WebSiteSurvey.Data
{
    public class WebSiteSurveyContext : DbContext
    {
        public WebSiteSurveyContext() : base("WebSiteSurvey")
        {
            
        }

        public DbSet<Models.WebSiteSurvey> WebSiteSurveys { get; set; }
    }
}