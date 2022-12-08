namespace DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PrevDbDump : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Donors",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        GrpId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Groups", t => t.GrpId, cascadeDelete: true)
                .Index(t => t.GrpId);
            
            CreateTable(
                "dbo.Groups",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Username = c.String(nullable: false, maxLength: 50),
                        Password = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.Username);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Donors", "GrpId", "dbo.Groups");
            DropIndex("dbo.Donors", new[] { "GrpId" });
            DropTable("dbo.Users");
            DropTable("dbo.Groups");
            DropTable("dbo.Donors");
        }
    }
}
