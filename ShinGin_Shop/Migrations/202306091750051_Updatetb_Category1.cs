namespace ShinGin_Shop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Updatetb_Category1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_Category", "Link", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.tb_Category", "Link");
        }
    }
}
