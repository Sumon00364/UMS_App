namespace UMS_App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Semester : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Semesters",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SemesterName = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Courses", "SemesterId", c => c.Int(nullable: false));
            CreateIndex("dbo.Courses", "SemesterId");
            AddForeignKey("dbo.Courses", "SemesterId", "dbo.Semesters", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Courses", "SemesterId", "dbo.Semesters");
            DropIndex("dbo.Courses", new[] { "SemesterId" });
            DropColumn("dbo.Courses", "SemesterId");
            DropTable("dbo.Semesters");
        }
    }
}
