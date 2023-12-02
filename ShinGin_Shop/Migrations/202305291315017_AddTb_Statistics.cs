namespace ShinGin_Shop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTb_Statistics : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tb_Statistics",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ViewNumber = c.Long(nullable: false),
                        Time = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.tb_Product", "ViewCount", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.tb_Product", "ViewCount");
            DropTable("dbo.tb_Statistics");
        }
    }
}
