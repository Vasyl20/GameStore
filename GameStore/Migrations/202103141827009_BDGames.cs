namespace GameStore.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BDGames : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tbGames", "Price", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.tbGames", "Price");
        }
    }
}
