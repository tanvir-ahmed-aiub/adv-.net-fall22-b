namespace CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CourseDepartmentTableAddedCgpaAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        DeptId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 10),
                    })
                .PrimaryKey(t => t.DeptId);
            
            AddColumn("dbo.Students", "Cgpa", c => c.Single());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "Cgpa");
            DropTable("dbo.Departments");
            DropTable("dbo.Courses");
        }
    }
}
