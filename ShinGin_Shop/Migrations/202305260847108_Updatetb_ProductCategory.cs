namespace ShinGin_Shop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Updatetb_ProductCategory : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.tb_ProductCategory", "Icon", c => c.String(maxLength: 250));
            AlterColumn("dbo.tb_ProductCategory", "Description", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.tb_ProductCategory", "Description", c => c.String(maxLength: 150));
            AlterColumn("dbo.tb_ProductCategory", "Icon", c => c.Int(nullable: false));
        }
    }
}
