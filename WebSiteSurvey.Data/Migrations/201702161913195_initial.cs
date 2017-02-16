namespace WebSiteSurvey.Data.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.WebSiteSurveys",
                c => new
                    {
                        ReponseId = c.Guid(nullable: false),
                        Name = c.String(),
                        Email = c.String(),
                        Age = c.Int(nullable: false),
                        Gender = c.String(),
                        Country = c.String(),
                        ExperienceRating = c.Short(nullable: false),
                        Suggestion = c.String(),
                        Referrer = c.String(),
                        SubmissionDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ReponseId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.WebSiteSurveys");
        }
    }
}
