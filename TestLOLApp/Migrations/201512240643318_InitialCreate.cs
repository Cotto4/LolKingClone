namespace TestLOLApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ChampionIDMaps",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Championid = c.Int(nullable: false),
                        key = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ChampionIDMaps");
        }
    }
}
