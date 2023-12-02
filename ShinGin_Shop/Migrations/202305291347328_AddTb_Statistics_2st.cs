namespace ShinGin_Shop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTb_Statistics_2st : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_Statistics", "DTime", c => c.DateTime(nullable: false));
            DropColumn("dbo.tb_Statistics", "Time");
        }
        
        public override void Down()
        {
            AddColumn("dbo.tb_Statistics", "Time", c => c.DateTime(nullable: false));
            DropColumn("dbo.tb_Statistics", "DTime");
        }
    }
}
