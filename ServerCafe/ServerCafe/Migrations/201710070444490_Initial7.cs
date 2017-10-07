namespace ServerCafe.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial7 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ThanhPhanDoUong",
                c => new
                    {
                        IDThanhPhanDoUong = c.String(nullable: false, maxLength: 128),
                        IDDoUong = c.String(maxLength: 128),
                        IDNguyenLieu = c.String(maxLength: 128),
                        SoLuong = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.IDThanhPhanDoUong)
                .ForeignKey("dbo.DoUong", t => t.IDDoUong)
                .ForeignKey("dbo.NguyenLieu", t => t.IDNguyenLieu)
                .Index(t => t.IDDoUong)
                .Index(t => t.IDNguyenLieu);
            
            AlterColumn("dbo.NguyenLieu", "Gia", c => c.Single(nullable: false));
            AlterColumn("dbo.NguyenLieu", "SoLuong", c => c.Single(nullable: false));
            DropColumn("dbo.DoUong", "ThanhPhan");
        }
        
        public override void Down()
        {
            AddColumn("dbo.DoUong", "ThanhPhan", c => c.String());
            DropForeignKey("dbo.ThanhPhanDoUong", "IDNguyenLieu", "dbo.NguyenLieu");
            DropForeignKey("dbo.ThanhPhanDoUong", "IDDoUong", "dbo.DoUong");
            DropIndex("dbo.ThanhPhanDoUong", new[] { "IDNguyenLieu" });
            DropIndex("dbo.ThanhPhanDoUong", new[] { "IDDoUong" });
            AlterColumn("dbo.NguyenLieu", "SoLuong", c => c.Int(nullable: false));
            AlterColumn("dbo.NguyenLieu", "Gia", c => c.Int(nullable: false));
            DropTable("dbo.ThanhPhanDoUong");
        }
    }
}
