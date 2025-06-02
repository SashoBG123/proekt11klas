namespace Project11a11.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class firstMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.VegetableTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Vegetables",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        Price = c.Double(nullable: false),
                        VegetableTypeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.VegetableTypes", t => t.VegetableTypeId, cascadeDelete: true)
                .Index(t => t.VegetableTypeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Vegetables", "VegetableTypeId", "dbo.VegetableTypes");
            DropIndex("dbo.Vegetables", new[] { "VegetableTypeId" });
            DropTable("dbo.Vegetables");
            DropTable("dbo.VegetableTypes");
        }
    }
}
