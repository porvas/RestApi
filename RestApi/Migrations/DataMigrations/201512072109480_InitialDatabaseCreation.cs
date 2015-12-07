namespace RestApi.Migrations.DataMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDatabaseCreation : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ads",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 100),
                        Desc = c.String(nullable: false, maxLength: 1000),
                        Price = c.Single(nullable: false),
                        phone_contact = c.Boolean(nullable: false),
                        email_contact = c.Boolean(nullable: false),
                        Phone = c.String(maxLength: 10),
                        CategoryId = c.Int(nullable: false),
                        SubcategoryId = c.Int(nullable: false),
                        UserId = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .Index(t => t.CategoryId);
            
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Subcategories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 30),
                        CategoryId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
                .Index(t => t.CategoryId);
            
            CreateTable(
                "dbo.Images",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Path = c.String(nullable: false, maxLength: 50),
                        AdId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Ads", t => t.AdId, cascadeDelete: true)
                .Index(t => t.AdId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Images", "AdId", "dbo.Ads");
            DropForeignKey("dbo.Ads", "CategoryId", "dbo.Categories");
            DropForeignKey("dbo.Subcategories", "CategoryId", "dbo.Categories");
            DropIndex("dbo.Images", new[] { "AdId" });
            DropIndex("dbo.Subcategories", new[] { "CategoryId" });
            DropIndex("dbo.Ads", new[] { "CategoryId" });
            DropTable("dbo.Images");
            DropTable("dbo.Subcategories");
            DropTable("dbo.Categories");
            DropTable("dbo.Ads");
        }
    }
}
