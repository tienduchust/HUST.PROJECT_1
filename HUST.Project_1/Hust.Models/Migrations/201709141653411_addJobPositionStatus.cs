namespace Hust.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addJobPositionStatus : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.JobPositions",
                c => new
                    {
                        JobPositionId = c.Guid(nullable: false),
                        JobName = c.String(),
                        StatusId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.JobPositionId)
                .ForeignKey("dbo.Status", t => t.StatusId, cascadeDelete: true)
                .Index(t => t.StatusId);
            
            CreateTable(
                "dbo.Status",
                c => new
                    {
                        StatusId = c.Guid(nullable: false),
                        Description = c.String(),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.StatusId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.JobPositions", "StatusId", "dbo.Status");
            DropIndex("dbo.JobPositions", new[] { "StatusId" });
            DropTable("dbo.Status");
            DropTable("dbo.JobPositions");
        }
    }
}
