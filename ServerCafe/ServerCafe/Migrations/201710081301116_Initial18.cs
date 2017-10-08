namespace ServerCafe.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial18 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Ban",
                c => new
                    {
                        IDBan = c.String(nullable: false, maxLength: 128),
                        TenBan = c.String(),
                        IDKhuVuc = c.String(maxLength: 128),
                        TrangThai = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IDBan)
                .ForeignKey("dbo.KhuVuc", t => t.IDKhuVuc)
                .Index(t => t.IDKhuVuc);
            
            CreateTable(
                "dbo.KhuVuc",
                c => new
                    {
                        IDKhuVuc = c.String(nullable: false, maxLength: 128),
                        TenKhuVuc = c.String(),
                    })
                .PrimaryKey(t => t.IDKhuVuc);
            
            CreateTable(
                "dbo.Order",
                c => new
                    {
                        IDOrder = c.String(nullable: false, maxLength: 128),
                        IDBan = c.String(maxLength: 128),
                        IDThongTinCaNhan = c.String(maxLength: 128),
                        ThoiGianVao = c.String(),
                        DaThanhToan = c.Boolean(nullable: false),
                        PhuThu = c.Int(nullable: false),
                        GhiChu = c.String(),
                    })
                .PrimaryKey(t => t.IDOrder)
                .ForeignKey("dbo.Ban", t => t.IDBan)
                .ForeignKey("dbo.ThongTinCaNhan", t => t.IDThongTinCaNhan)
                .Index(t => t.IDBan)
                .Index(t => t.IDThongTinCaNhan);
            
            CreateTable(
                "dbo.ChiTietOrder",
                c => new
                    {
                        IDChiTietOrder = c.String(nullable: false, maxLength: 128),
                        IDOrder = c.String(maxLength: 128),
                        IDDoUong = c.String(maxLength: 128),
                        SoLuong = c.Int(nullable: false),
                        GhiChu = c.String(),
                        ThoiGian = c.String(),
                        DaIn = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.IDChiTietOrder)
                .ForeignKey("dbo.DoUong", t => t.IDDoUong)
                .ForeignKey("dbo.Order", t => t.IDOrder)
                .Index(t => t.IDOrder)
                .Index(t => t.IDDoUong);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Order", "IDThongTinCaNhan", "dbo.ThongTinCaNhan");
            DropForeignKey("dbo.ChiTietOrder", "IDOrder", "dbo.Order");
            DropForeignKey("dbo.ChiTietOrder", "IDDoUong", "dbo.DoUong");
            DropForeignKey("dbo.Order", "IDBan", "dbo.Ban");
            DropForeignKey("dbo.Ban", "IDKhuVuc", "dbo.KhuVuc");
            DropIndex("dbo.ChiTietOrder", new[] { "IDDoUong" });
            DropIndex("dbo.ChiTietOrder", new[] { "IDOrder" });
            DropIndex("dbo.Order", new[] { "IDThongTinCaNhan" });
            DropIndex("dbo.Order", new[] { "IDBan" });
            DropIndex("dbo.Ban", new[] { "IDKhuVuc" });
            DropTable("dbo.ChiTietOrder");
            DropTable("dbo.Order");
            DropTable("dbo.KhuVuc");
            DropTable("dbo.Ban");
        }
    }
}
