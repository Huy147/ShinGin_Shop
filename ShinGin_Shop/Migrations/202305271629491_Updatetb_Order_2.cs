namespace ShinGin_Shop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Updatetb_Order_2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_Order", "Email", c => c.String());
            AlterColumn("dbo.tb_Order", "CustomerName", c => c.String(nullable: false));
            AlterColumn("dbo.tb_Order", "Phone", c => c.String(nullable: false));
            AlterColumn("dbo.tb_Order", "Address", c => c.String(nullable: false));
            AlterColumn("dbo.tb_Order", "TotalAmount", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.tb_Order", "Quantity", c => c.Int(nullable: false));
            AlterColumn("dbo.tb_Order", "TypePayment", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.tb_Order", "TypePayment", c => c.String());
            AlterColumn("dbo.tb_Order", "Quantity", c => c.String());
            AlterColumn("dbo.tb_Order", "TotalAmount", c => c.String());
            AlterColumn("dbo.tb_Order", "Address", c => c.String(nullable: false, maxLength: 250));
            AlterColumn("dbo.tb_Order", "Phone", c => c.String(nullable: false, maxLength: 10));
            AlterColumn("dbo.tb_Order", "CustomerName", c => c.String(nullable: false, maxLength: 150));
            DropColumn("dbo.tb_Order", "Email");
        }
    }
}
