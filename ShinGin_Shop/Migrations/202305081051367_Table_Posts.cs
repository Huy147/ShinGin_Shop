namespace ShinGin_Shop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Table_Posts : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_Posts", "IsActive", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.tb_Posts", "IsActive");
        }
    }
}
