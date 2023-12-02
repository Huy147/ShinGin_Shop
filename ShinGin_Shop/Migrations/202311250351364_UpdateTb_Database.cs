namespace ShinGin_Shop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateTb_Database : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.tb_Order", "Status");
            DropTable("dbo.tb_ProductReview");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.tb_ProductReview",
                c => new
                    {
                        ProductId = c.Int(nullable: false),
                        FullName = c.String(nullable: false, maxLength: 128),
                        Rating = c.Int(nullable: false),
                        ReviewMessage = c.String(),
                        Time = c.DateTime(nullable: false),
                        IsChanged = c.Boolean(nullable: false), 
                    })
                .PrimaryKey(t => new { t.ProductId, t.FullName });
            
            AddColumn("dbo.tb_Order", "Status", c => c.Int(nullable: false));
        } 
    }
}
