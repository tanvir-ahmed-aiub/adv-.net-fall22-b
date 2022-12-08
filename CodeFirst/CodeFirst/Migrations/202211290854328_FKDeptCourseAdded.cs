namespace CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FKDeptCourseAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "OfferedBy", c => c.Int(nullable: false));
            CreateIndex("dbo.Courses", "OfferedBy");
            AddForeignKey("dbo.Courses", "OfferedBy", "dbo.Departments", "DeptId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Courses", "OfferedBy", "dbo.Departments");
            DropIndex("dbo.Courses", new[] { "OfferedBy" });
            DropColumn("dbo.Courses", "OfferedBy");
        }
    }
}
