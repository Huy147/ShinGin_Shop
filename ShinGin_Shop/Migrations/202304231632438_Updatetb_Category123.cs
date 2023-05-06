namespace ShinGin_Shop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Updatetb_Category123 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_News", "Alias", c => c.String());
            AddColumn("dbo.tb_Product", "Alias", c => c.String());
            AlterColumn("dbo.tb_Category", "Alias", c => c.String());
            AlterColumn("dbo.tb_Category", "Description", c => c.String(maxLength: 3000));
            AlterColumn("dbo.tb_News", "Description", c => c.String(maxLength: 4000));
            AlterColumn("dbo.tb_Posts", "Alias", c => c.String());
            AlterColumn("dbo.tb_Posts", "Description", c => c.String(maxLength: 3000));
            AlterColumn("dbo.tb_Product", "Description", c => c.String(maxLength: 4000));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.tb_Product", "Description", c => c.String(maxLength: 250));
            AlterColumn("dbo.tb_Posts", "Description", c => c.String());
            AlterColumn("dbo.tb_Posts", "Alias", c => c.String(maxLength: 150));
            AlterColumn("dbo.tb_News", "Description", c => c.String());
            AlterColumn("dbo.tb_Category", "Description", c => c.String());
            AlterColumn("dbo.tb_Category", "Alias", c => c.String(maxLength: 4000));
            DropColumn("dbo.tb_Product", "Alias");
            DropColumn("dbo.tb_News", "Alias");
        }
    }
}
