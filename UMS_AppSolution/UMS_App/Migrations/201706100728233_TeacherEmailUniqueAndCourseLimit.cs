namespace UMS_App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TeacherEmailUniqueAndCourseLimit : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Teachers", "CreditLimit", c => c.Int(nullable: false));
            AlterColumn("dbo.AspNetUsers", "UserName", c => c.String(nullable: false));
            CreateIndex("dbo.Teachers", "Email", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Teachers", new[] { "Email" });
            AlterColumn("dbo.AspNetUsers", "UserName", c => c.String());
            DropColumn("dbo.Teachers", "CreditLimit");
        }
    }
}
