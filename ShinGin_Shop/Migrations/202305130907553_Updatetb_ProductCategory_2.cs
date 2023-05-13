namespace ShinGin_Shop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Updatetb_ProductCategory_2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_ProductCategory", "Title", c => c.String(nullable: false, maxLength: 150));
            DropColumn("dbo.tb_ProductCategory", "Tilte");
        }
        
        public override void Down()
        {
            AddColumn("dbo.tb_ProductCategory", "Tilte", c => c.String(nullable: false, maxLength: 150));
            DropColumn("dbo.tb_ProductCategory", "Title");
        }
    }
}
