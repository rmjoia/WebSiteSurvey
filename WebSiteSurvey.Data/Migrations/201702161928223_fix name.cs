namespace WebSiteSurvey.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fixname : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.WebSiteSurveys");
            AddColumn("dbo.WebSiteSurveys", "ResponseId", c => c.Guid(nullable: false));
            AddPrimaryKey("dbo.WebSiteSurveys", "ResponseId");
            DropColumn("dbo.WebSiteSurveys", "ReponseId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.WebSiteSurveys", "ReponseId", c => c.Guid(nullable: false));
            DropPrimaryKey("dbo.WebSiteSurveys");
            DropColumn("dbo.WebSiteSurveys", "ResponseId");
            AddPrimaryKey("dbo.WebSiteSurveys", "ReponseId");
        }
    }
}
