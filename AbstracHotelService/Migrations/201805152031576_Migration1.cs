namespace AbstracHotelService.Migrations
{
    using System.Data.Entity.Migrations;
    
    public partial class Migration1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Administrators",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AdminFIO = c.String(nullable: false),
                        UserName = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        Zaschita = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Oplatas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ZakazId = c.Int(nullable: false),
                        DateCreate = c.DateTime(nullable: false),
                        Summ = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Zakazs", t => t.ZakazId, cascadeDelete: true)
                .Index(t => t.ZakazId);
            
            CreateTable(
                "dbo.Zakazs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PosetitelId = c.Int(nullable: false),
                        ZakazStatus = c.Int(nullable: false),
                        DateCreate = c.DateTime(nullable: false),
                        DateImplement = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Posetitels", t => t.PosetitelId, cascadeDelete: true)
                .Index(t => t.PosetitelId);
            
            CreateTable(
                "dbo.Posetitels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserName = c.String(nullable: false),
                        Password = c.String(nullable: false),
                        Zaschita = c.String(nullable: false),
                        Bonuses = c.Int(nullable: false),
                        Active = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.UslugaZakazs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UslugaId = c.Int(nullable: false),
                        ZakazId = c.Int(nullable: false),
                        Count = c.Int(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Uslugas", t => t.UslugaId, cascadeDelete: true)
                .ForeignKey("dbo.Zakazs", t => t.ZakazId, cascadeDelete: true)
                .Index(t => t.UslugaId)
                .Index(t => t.ZakazId);
            
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
            DropForeignKey("dbo.UslugaZakazs", "ZakazId", "dbo.Zakazs");
            DropForeignKey("dbo.UslugaZakazs", "UslugaId", "dbo.Uslugas");
            DropForeignKey("dbo.Zakazs", "PosetitelId", "dbo.Posetitels");
            DropForeignKey("dbo.Oplatas", "ZakazId", "dbo.Zakazs");
            DropIndex("dbo.UslugaZakazs", new[] { "ZakazId" });
            DropIndex("dbo.UslugaZakazs", new[] { "UslugaId" });
            DropIndex("dbo.Zakazs", new[] { "PosetitelId" });
            DropIndex("dbo.Oplatas", new[] { "ZakazId" });
            DropTable("dbo.Uslugas");
            DropTable("dbo.UslugaZakazs");
            DropTable("dbo.Posetitels");
            DropTable("dbo.Zakazs");
            DropTable("dbo.Oplatas");
            DropTable("dbo.Administrators");
        }
    }
}
