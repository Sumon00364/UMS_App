namespace UMS_App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ClassRoomAllocate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ClassRoomAllocates",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CourseId = c.Int(nullable: false),
                        RoomId = c.Int(nullable: false),
                        DayId = c.Int(nullable: false),
                        FromTime = c.Time(nullable: false, precision: 7),
                        ToTime = c.Time(nullable: false, precision: 7),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Courses", t => t.CourseId, cascadeDelete: true)
                .ForeignKey("dbo.Rooms", t => t.RoomId, cascadeDelete: true)
                .Index(t => t.CourseId)
                .Index(t => t.RoomId);
            
            CreateTable(
                "dbo.Rooms",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RoomName = c.String(nullable: false, maxLength: 10),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ClassRoomAllocates", "RoomId", "dbo.Rooms");
            DropForeignKey("dbo.ClassRoomAllocates", "CourseId", "dbo.Courses");
            DropIndex("dbo.ClassRoomAllocates", new[] { "RoomId" });
            DropIndex("dbo.ClassRoomAllocates", new[] { "CourseId" });
            DropTable("dbo.Rooms");
            DropTable("dbo.ClassRoomAllocates");
        }
    }
}
