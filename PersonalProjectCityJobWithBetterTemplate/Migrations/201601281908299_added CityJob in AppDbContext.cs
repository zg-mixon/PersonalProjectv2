namespace PersonalProjectCityJobWithBetterTemplate.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedCityJobinAppDbContext : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CityJobs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Salary = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Active = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Cities", "CityJob_Id", c => c.Int());
            AddColumn("dbo.Jobs", "CityJob_Id", c => c.Int());
            CreateIndex("dbo.Cities", "CityJob_Id");
            CreateIndex("dbo.Jobs", "CityJob_Id");
            AddForeignKey("dbo.Cities", "CityJob_Id", "dbo.CityJobs", "Id");
            AddForeignKey("dbo.Jobs", "CityJob_Id", "dbo.CityJobs", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Jobs", "CityJob_Id", "dbo.CityJobs");
            DropForeignKey("dbo.Cities", "CityJob_Id", "dbo.CityJobs");
            DropIndex("dbo.Jobs", new[] { "CityJob_Id" });
            DropIndex("dbo.Cities", new[] { "CityJob_Id" });
            DropColumn("dbo.Jobs", "CityJob_Id");
            DropColumn("dbo.Cities", "CityJob_Id");
            DropTable("dbo.CityJobs");
        }
    }
}
