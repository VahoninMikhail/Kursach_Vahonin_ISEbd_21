namespace AbstracHotelService.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Migration2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Posetitels", "PosetitelFIO", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Posetitels", "PosetitelFIO");
        }
    }
}
