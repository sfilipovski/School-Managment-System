namespace SchoolManagmentSystem.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class final : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "Semester", c => c.String());
            AddColumn("dbo.Students", "studentCode", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "studentCode");
            DropColumn("dbo.Courses", "Semester");
        }
    }
}
