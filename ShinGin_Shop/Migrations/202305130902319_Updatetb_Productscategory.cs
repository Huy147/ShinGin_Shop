namespace ShinGin_Shop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Updatetb_Productscategory : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_ProductCategory", "Alias", c => c.String(nullable: false, maxLength: 150));
            AddColumn("dbo.tb_ProductCategory", "Icon", c => c.Int(nullable: false));
            AlterColumn("dbo.tb_ProductCategory", "Description", c => c.String(maxLength: 150));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.tb_ProductCategory", "Description", c => c.String());
            DropColumn("dbo.tb_ProductCategory", "Icon");
            DropColumn("dbo.tb_ProductCategory", "Alias");
        }
    }
}
