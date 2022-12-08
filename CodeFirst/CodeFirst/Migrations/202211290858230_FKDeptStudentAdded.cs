namespace CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FKDeptStudentAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "DeptId", c => c.Int(nullable: false));
            CreateIndex("dbo.Students", "DeptId");
            AddForeignKey("dbo.Students", "DeptId", "dbo.Departments", "DeptId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "DeptId", "dbo.Departments");
            DropIndex("dbo.Students", new[] { "DeptId" });
            DropColumn("dbo.Students", "DeptId");
        }
    }
}
