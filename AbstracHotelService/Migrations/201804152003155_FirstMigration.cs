namespace AbstracHotelService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ispolnitels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IspolnitelFIO = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Zakazs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PosetitelId = c.Int(nullable: false),
                        UslugaId = c.Int(nullable: false),
                        IspolnitelId = c.Int(),
                        Count = c.Int(nullable: false),
                        Sum = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Status = c.Int(nullable: false),
                        DateCreate = c.DateTime(nullable: false),
                        DateImplement = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Ispolnitels", t => t.IspolnitelId)
                .ForeignKey("dbo.Posetitels", t => t.PosetitelId, cascadeDelete: true)
                .ForeignKey("dbo.Uslugas", t => t.UslugaId, cascadeDelete: true)
                .Index(t => t.PosetitelId)
                .Index(t => t.UslugaId)
                .Index(t => t.IspolnitelId);
            
            CreateTable(
                "dbo.Posetitels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PosetitelFIO = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Uslugas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UslugaName = c.String(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Zakazs", "UslugaId", "dbo.Uslugas");
            DropForeignKey("dbo.Zakazs", "PosetitelId", "dbo.Posetitels");
            DropForeignKey("dbo.Zakazs", "IspolnitelId", "dbo.Ispolnitels");
            DropIndex("dbo.Zakazs", new[] { "IspolnitelId" });
            DropIndex("dbo.Zakazs", new[] { "UslugaId" });
            DropIndex("dbo.Zakazs", new[] { "PosetitelId" });
            DropTable("dbo.Uslugas");
            DropTable("dbo.Posetitels");
            DropTable("dbo.Zakazs");
            DropTable("dbo.Ispolnitels");
        }
    }
}
