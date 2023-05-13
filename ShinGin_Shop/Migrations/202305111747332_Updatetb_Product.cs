﻿namespace ShinGin_Shop.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Updatetb_Product : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_Product", "IsActive", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.tb_Product", "IsActive");
        }
    }
}
