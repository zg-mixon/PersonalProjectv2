namespace PersonalProjectCityJobWithBetterTemplate.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addeddescriptionforjobmodel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Jobs", "Description", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Jobs", "Description");
        }
    }
}
