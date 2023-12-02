namespace ShinGin_Shop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Updatetb_CommonAbstract : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_Advertisement", "ModifiedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.tb_Category", "ModifiedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.tb_News", "ModifiedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.tb_Posts", "ModifiedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.tb_Contact", "ModifiedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.tb_Order", "ModifiedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.tb_Product", "ModifiedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.tb_ProductCategory", "ModifiedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.tb_Subscribe", "ModifiedDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.tb_Advertisement", "ModifiedbyDate");
            DropColumn("dbo.tb_Category", "ModifiedbyDate");
            DropColumn("dbo.tb_News", "ModifiedbyDate");
            DropColumn("dbo.tb_Posts", "ModifiedbyDate");
            DropColumn("dbo.tb_Contact", "ModifiedbyDate");
            DropColumn("dbo.tb_Order", "ModifiedbyDate");
            DropColumn("dbo.tb_Product", "ModifiedbyDate");
            DropColumn("dbo.tb_ProductCategory", "ModifiedbyDate");
            DropColumn("dbo.tb_Subscribe", "ModifiedbyDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.tb_Subscribe", "ModifiedbyDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.tb_ProductCategory", "ModifiedbyDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.tb_Product", "ModifiedbyDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.tb_Order", "ModifiedbyDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.tb_Contact", "ModifiedbyDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.tb_Posts", "ModifiedbyDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.tb_News", "ModifiedbyDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.tb_Category", "ModifiedbyDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.tb_Advertisement", "ModifiedbyDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.tb_Subscribe", "ModifiedDate");
            DropColumn("dbo.tb_ProductCategory", "ModifiedDate");
            DropColumn("dbo.tb_Product", "ModifiedDate");
            DropColumn("dbo.tb_Order", "ModifiedDate");
            DropColumn("dbo.tb_Contact", "ModifiedDate");
            DropColumn("dbo.tb_Posts", "ModifiedDate");
            DropColumn("dbo.tb_News", "ModifiedDate");
            DropColumn("dbo.tb_Category", "ModifiedDate");
            DropColumn("dbo.tb_Advertisement", "ModifiedDate");
        }
    }
}
