namespace ServerCafe.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial4 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.NguyenLieu", "DoUong_IDDoUong", "dbo.DoUong");
            DropIndex("dbo.NguyenLieu", new[] { "DoUong_IDDoUong" });
            DropColumn("dbo.NguyenLieu", "DoUong_IDDoUong");
        }
        
        public override void Down()
        {
            AddColumn("dbo.NguyenLieu", "DoUong_IDDoUong", c => c.String(maxLength: 128));
            CreateIndex("dbo.NguyenLieu", "DoUong_IDDoUong");
            AddForeignKey("dbo.NguyenLieu", "DoUong_IDDoUong", "dbo.DoUong", "IDDoUong");
        }
    }
}
