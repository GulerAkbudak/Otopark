namespace Otopark.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Brands",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BrandName = c.String(maxLength: 70, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Plaque = c.String(maxLength: 8000, unicode: false),
                        NameSurname = c.String(maxLength: 8000, unicode: false),
                        Telephone = c.String(maxLength: 30, unicode: false),
                        Year = c.String(maxLength: 70, unicode: false),
                        Color = c.String(maxLength: 70, unicode: false),
                        Comment = c.String(maxLength: 8000, unicode: false),
                        BrandId = c.Int(nullable: false),
                        SerieId = c.Int(nullable: false),
                        CarParkingSpaceId = c.Int(),
                        EntryDate = c.DateTime(),
                        Deleted = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Brands", t => t.BrandId)
                .ForeignKey("dbo.CarParkingSpaces", t => t.CarParkingSpaceId)
                .ForeignKey("dbo.Series", t => t.SerieId)
                .Index(t => t.BrandId)
                .Index(t => t.SerieId)
                .Index(t => t.CarParkingSpaceId);
            
            CreateTable(
                "dbo.CarParkingSpaces",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ParkingSpaces = c.String(maxLength: 70, unicode: false),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Series",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        BrandId = c.Int(nullable: false),
                        SerieName = c.String(maxLength: 70, unicode: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Brands", t => t.BrandId)
                .Index(t => t.BrandId);
            
            CreateTable(
                "dbo.Sells",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CustomerId = c.Int(nullable: false),
                        CarParkingSpaceId = c.Int(nullable: false),
                        Time = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        EntryDate = c.DateTime(nullable: false),
                        ExitDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CarParkingSpaces", t => t.CarParkingSpaceId)
                .ForeignKey("dbo.Customers", t => t.CustomerId)
                .Index(t => t.CustomerId)
                .Index(t => t.CarParkingSpaceId);
            
            CreateTable(
                "dbo.Tariffs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StartHour = c.Int(nullable: false),
                        EndHour = c.Int(nullable: false),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Sells", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.Sells", "CarParkingSpaceId", "dbo.CarParkingSpaces");
            DropForeignKey("dbo.Customers", "SerieId", "dbo.Series");
            DropForeignKey("dbo.Series", "BrandId", "dbo.Brands");
            DropForeignKey("dbo.Customers", "CarParkingSpaceId", "dbo.CarParkingSpaces");
            DropForeignKey("dbo.Customers", "BrandId", "dbo.Brands");
            DropIndex("dbo.Sells", new[] { "CarParkingSpaceId" });
            DropIndex("dbo.Sells", new[] { "CustomerId" });
            DropIndex("dbo.Series", new[] { "BrandId" });
            DropIndex("dbo.Customers", new[] { "CarParkingSpaceId" });
            DropIndex("dbo.Customers", new[] { "SerieId" });
            DropIndex("dbo.Customers", new[] { "BrandId" });
            DropTable("dbo.Tariffs");
            DropTable("dbo.Sells");
            DropTable("dbo.Series");
            DropTable("dbo.CarParkingSpaces");
            DropTable("dbo.Customers");
            DropTable("dbo.Brands");
        }
    }
}
