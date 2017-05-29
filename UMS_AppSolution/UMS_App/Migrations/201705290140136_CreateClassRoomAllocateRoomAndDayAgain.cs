namespace UMS_App.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateClassRoomAllocateRoomAndDayAgain : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.DepartmentClassRoomAllocates", "Department_Id", "dbo.Departments");
            DropForeignKey("dbo.DepartmentClassRoomAllocates", "ClassRoomAllocate_Id", "dbo.ClassRoomAllocates");
            DropForeignKey("dbo.Courses", "ClassRoomAllocate_Id", "dbo.ClassRoomAllocates");
            DropForeignKey("dbo.Courses", "DepartmentId", "dbo.Departments");
            DropForeignKey("dbo.Students", "DepartmentId", "dbo.Departments");
            DropForeignKey("dbo.Teachers", "DepartmentId", "dbo.Departments");
            DropForeignKey("dbo.Teachers", "DesignationId", "dbo.Designations");
            DropForeignKey("dbo.Courses", "SemesterId", "dbo.Semesters");
            DropForeignKey("dbo.ClassRoomAllocates", "DayId", "dbo.Days");
            DropForeignKey("dbo.ClassRoomAllocates", "RoomId", "dbo.Rooms");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "User_Id", "dbo.AspNetUsers");
            DropIndex("dbo.DepartmentClassRoomAllocates", new[] { "Department_Id" });
            DropIndex("dbo.DepartmentClassRoomAllocates", new[] { "ClassRoomAllocate_Id" });
            DropIndex("dbo.Courses", new[] { "ClassRoomAllocate_Id" });
            DropIndex("dbo.Courses", new[] { "DepartmentId" });
            DropIndex("dbo.Students", new[] { "DepartmentId" });
            DropIndex("dbo.Teachers", new[] { "DepartmentId" });
            DropIndex("dbo.Teachers", new[] { "DesignationId" });
            DropIndex("dbo.Courses", new[] { "SemesterId" });
            DropIndex("dbo.ClassRoomAllocates", new[] { "DayId" });
            DropIndex("dbo.ClassRoomAllocates", new[] { "RoomId" });
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "User_Id" });
            CreateIndex("dbo.ClassRoomAllocates", "CourseId");
            CreateIndex("dbo.ClassRoomAllocates", "DepartmentId");
            CreateIndex("dbo.Courses", "DepartmentId");
            CreateIndex("dbo.Students", "DepartmentId");
            CreateIndex("dbo.Teachers", "DepartmentId");
            CreateIndex("dbo.Teachers", "DesignationId");
            CreateIndex("dbo.Courses", "SemesterId");
            CreateIndex("dbo.ClassRoomAllocates", "DayId");
            CreateIndex("dbo.ClassRoomAllocates", "RoomId");
            CreateIndex("dbo.AspNetUserLogins", "UserId");
            CreateIndex("dbo.AspNetUserRoles", "RoleId");
            CreateIndex("dbo.AspNetUserRoles", "UserId");
            CreateIndex("dbo.AspNetUserClaims", "User_Id");
            AddForeignKey("dbo.ClassRoomAllocates", "CourseId", "dbo.Courses", "Id", cascadeDelete: true);
            AddForeignKey("dbo.ClassRoomAllocates", "DepartmentId", "dbo.Departments", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Courses", "DepartmentId", "dbo.Departments", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Students", "DepartmentId", "dbo.Departments", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Teachers", "DepartmentId", "dbo.Departments", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Teachers", "DesignationId", "dbo.Designations", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Courses", "SemesterId", "dbo.Semesters", "Id", cascadeDelete: true);
            AddForeignKey("dbo.ClassRoomAllocates", "DayId", "dbo.Days", "Id", cascadeDelete: true);
            AddForeignKey("dbo.ClassRoomAllocates", "RoomId", "dbo.Rooms", "Id", cascadeDelete: true);
            AddForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers", "Id", cascadeDelete: true);
            AddForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles", "Id", cascadeDelete: true);
            AddForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers", "Id", cascadeDelete: true);
            AddForeignKey("dbo.AspNetUserClaims", "User_Id", "dbo.AspNetUsers", "Id", cascadeDelete: true);
            DropColumn("dbo.Courses", "ClassRoomAllocate_Id");
            DropTable("dbo.DepartmentClassRoomAllocates");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.DepartmentClassRoomAllocates",
                c => new
                    {
                        Department_Id = c.Int(nullable: false),
                        ClassRoomAllocate_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Department_Id, t.ClassRoomAllocate_Id });
            
            AddColumn("dbo.Courses", "ClassRoomAllocate_Id", c => c.Int());
            DropForeignKey("dbo.AspNetUserClaims", "User_Id", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.ClassRoomAllocates", "RoomId", "dbo.Rooms");
            DropForeignKey("dbo.ClassRoomAllocates", "DayId", "dbo.Days");
            DropForeignKey("dbo.Courses", "SemesterId", "dbo.Semesters");
            DropForeignKey("dbo.Teachers", "DesignationId", "dbo.Designations");
            DropForeignKey("dbo.Teachers", "DepartmentId", "dbo.Departments");
            DropForeignKey("dbo.Students", "DepartmentId", "dbo.Departments");
            DropForeignKey("dbo.Courses", "DepartmentId", "dbo.Departments");
            DropForeignKey("dbo.ClassRoomAllocates", "DepartmentId", "dbo.Departments");
            DropForeignKey("dbo.ClassRoomAllocates", "CourseId", "dbo.Courses");
            DropIndex("dbo.AspNetUserClaims", new[] { "User_Id" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.ClassRoomAllocates", new[] { "RoomId" });
            DropIndex("dbo.ClassRoomAllocates", new[] { "DayId" });
            DropIndex("dbo.Courses", new[] { "SemesterId" });
            DropIndex("dbo.Teachers", new[] { "DesignationId" });
            DropIndex("dbo.Teachers", new[] { "DepartmentId" });
            DropIndex("dbo.Students", new[] { "DepartmentId" });
            DropIndex("dbo.Courses", new[] { "DepartmentId" });
            DropIndex("dbo.ClassRoomAllocates", new[] { "DepartmentId" });
            DropIndex("dbo.ClassRoomAllocates", new[] { "CourseId" });
            CreateIndex("dbo.AspNetUserClaims", "User_Id");
            CreateIndex("dbo.AspNetUserRoles", "UserId");
            CreateIndex("dbo.AspNetUserRoles", "RoleId");
            CreateIndex("dbo.AspNetUserLogins", "UserId");
            CreateIndex("dbo.ClassRoomAllocates", "RoomId");
            CreateIndex("dbo.ClassRoomAllocates", "DayId");
            CreateIndex("dbo.Courses", "SemesterId");
            CreateIndex("dbo.Teachers", "DesignationId");
            CreateIndex("dbo.Teachers", "DepartmentId");
            CreateIndex("dbo.Students", "DepartmentId");
            CreateIndex("dbo.Courses", "DepartmentId");
            CreateIndex("dbo.Courses", "ClassRoomAllocate_Id");
            CreateIndex("dbo.DepartmentClassRoomAllocates", "ClassRoomAllocate_Id");
            CreateIndex("dbo.DepartmentClassRoomAllocates", "Department_Id");
            AddForeignKey("dbo.AspNetUserClaims", "User_Id", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles", "Id");
            AddForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers", "Id");
            AddForeignKey("dbo.ClassRoomAllocates", "RoomId", "dbo.Rooms", "Id");
            AddForeignKey("dbo.ClassRoomAllocates", "DayId", "dbo.Days", "Id");
            AddForeignKey("dbo.Courses", "SemesterId", "dbo.Semesters", "Id");
            AddForeignKey("dbo.Teachers", "DesignationId", "dbo.Designations", "Id");
            AddForeignKey("dbo.Teachers", "DepartmentId", "dbo.Departments", "Id");
            AddForeignKey("dbo.Students", "DepartmentId", "dbo.Departments", "Id");
            AddForeignKey("dbo.Courses", "DepartmentId", "dbo.Departments", "Id");
            AddForeignKey("dbo.Courses", "ClassRoomAllocate_Id", "dbo.ClassRoomAllocates", "Id");
            AddForeignKey("dbo.DepartmentClassRoomAllocates", "ClassRoomAllocate_Id", "dbo.ClassRoomAllocates", "Id", cascadeDelete: true);
            AddForeignKey("dbo.DepartmentClassRoomAllocates", "Department_Id", "dbo.Departments", "Id", cascadeDelete: true);
        }
    }
}
