namespace SchoolManagmentSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initialUpdate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        courseId = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false),
                        Code = c.Int(nullable: false),
                        Credits = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.courseId);
            
            CreateTable(
                "dbo.Instructors",
                c => new
                    {
                        instructorId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        HireDate = c.DateTime(nullable: false),
                        Office = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.instructorId);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        studentId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(nullable: false),
                        EnrollmentDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.studentId);
            
            CreateTable(
                "dbo.InstructorCourses",
                c => new
                    {
                        Instructor_instructorId = c.Int(nullable: false),
                        Course_courseId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Instructor_instructorId, t.Course_courseId })
                .ForeignKey("dbo.Instructors", t => t.Instructor_instructorId, cascadeDelete: true)
                .ForeignKey("dbo.Courses", t => t.Course_courseId, cascadeDelete: true)
                .Index(t => t.Instructor_instructorId)
                .Index(t => t.Course_courseId);
            
            CreateTable(
                "dbo.StudentCourses",
                c => new
                    {
                        Student_studentId = c.Int(nullable: false),
                        Course_courseId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Student_studentId, t.Course_courseId })
                .ForeignKey("dbo.Students", t => t.Student_studentId, cascadeDelete: true)
                .ForeignKey("dbo.Courses", t => t.Course_courseId, cascadeDelete: true)
                .Index(t => t.Student_studentId)
                .Index(t => t.Course_courseId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.StudentCourses", "Course_courseId", "dbo.Courses");
            DropForeignKey("dbo.StudentCourses", "Student_studentId", "dbo.Students");
            DropForeignKey("dbo.InstructorCourses", "Course_courseId", "dbo.Courses");
            DropForeignKey("dbo.InstructorCourses", "Instructor_instructorId", "dbo.Instructors");
            DropIndex("dbo.StudentCourses", new[] { "Course_courseId" });
            DropIndex("dbo.StudentCourses", new[] { "Student_studentId" });
            DropIndex("dbo.InstructorCourses", new[] { "Course_courseId" });
            DropIndex("dbo.InstructorCourses", new[] { "Instructor_instructorId" });
            DropTable("dbo.StudentCourses");
            DropTable("dbo.InstructorCourses");
            DropTable("dbo.Students");
            DropTable("dbo.Instructors");
            DropTable("dbo.Courses");
        }
    }
}
