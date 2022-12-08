namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TablesModifiedAndFKAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Books", "CategoryId", c => c.Int(nullable: false));
            AlterColumn("dbo.Books", "Name", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Books", "Author", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Categories", "Name", c => c.String(nullable: false, maxLength: 50));
            CreateIndex("dbo.Books", "CategoryId");
            AddForeignKey("dbo.Books", "CategoryId", "dbo.Categories", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Books", "CategoryId", "dbo.Categories");
            DropIndex("dbo.Books", new[] { "CategoryId" });
            AlterColumn("dbo.Categories", "Name", c => c.String());
            AlterColumn("dbo.Books", "Author", c => c.String());
            AlterColumn("dbo.Books", "Name", c => c.String());
            DropColumn("dbo.Books", "CategoryId");
        }
    }
}
