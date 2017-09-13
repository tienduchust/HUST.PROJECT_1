namespace Hust.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Files",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FileId = c.Guid(nullable: false),
                        ReferenceType = c.String(),
                        ReferenceId = c.Guid(nullable: false),
                        FileName = c.String(),
                        FileType = c.String(),
                        GroupKey = c.String(),
                        Size = c.Long(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                        Data = c.Binary(),
                        CreatedBy = c.Guid(nullable: false),
                        CreatedDateTime = c.DateTime(nullable: false),
                        UpdatedBy = c.Guid(nullable: false),
                        UpdatedDateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Projects",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProjectId = c.Guid(nullable: false),
                        ProjectName = c.String(),
                        UserId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Guid(nullable: false),
                        UserName = c.String(),
                        Password = c.String(),
                        FirstName = c.String(),
                        MiddleName = c.String(),
                        LastName = c.String(),
                        BornDate = c.DateTime(nullable: false),
                        PhoneNumber = c.Int(nullable: false),
                        Email = c.String(),
                        Salary = c.String(),
                        Status = c.String(),
                        Project_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Projects", t => t.Project_Id)
                .Index(t => t.Project_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "Project_Id", "dbo.Projects");
            DropIndex("dbo.Users", new[] { "Project_Id" });
            DropTable("dbo.Users");
            DropTable("dbo.Projects");
            DropTable("dbo.Files");
        }
    }
}
