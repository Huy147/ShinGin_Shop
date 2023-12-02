namespace ShinGin_Shop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Updatetb_OrderDetail : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_OrderDetail", "Quantity", c => c.Int(nullable: false));
            DropColumn("dbo.tb_OrderDetail", "Quatity");
        }
        
        public override void Down()
        {
            AddColumn("dbo.tb_OrderDetail", "Quatity", c => c.Int(nullable: false));
            DropColumn("dbo.tb_OrderDetail", "Quantity");
        }
    }
}
