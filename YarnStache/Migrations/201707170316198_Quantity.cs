namespace YarnStache.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Quantity : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Yarns", "Quantity", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Yarns", "Quantity");
        }
    }
}
