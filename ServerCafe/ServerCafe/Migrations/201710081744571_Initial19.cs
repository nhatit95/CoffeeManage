namespace ServerCafe.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial19 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Order", "ThoiGianRa", c => c.String());
            DropColumn("dbo.Ban", "TrangThai");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Ban", "TrangThai", c => c.Int(nullable: false));
            DropColumn("dbo.Order", "ThoiGianRa");
        }
    }
}
