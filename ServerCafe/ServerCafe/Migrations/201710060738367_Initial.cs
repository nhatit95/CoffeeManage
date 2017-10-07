namespace ServerCafe.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ChucVu",
                c => new
                    {
                        IDChucVu = c.String(nullable: false, maxLength: 10),
                        TenChucVu = c.String(),
                        LuongCa = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IDChucVu);
            
            CreateTable(
                "dbo.ThongTinCaNhan",
                c => new
                    {
                        IDUser = c.String(nullable: false, maxLength: 10),
                        Email = c.String(),
                        IDChucVu = c.String(maxLength: 10),
                        Ten = c.String(),
                        DiaChi = c.String(),
                        SDT = c.String(),
                        NgaySinh = c.String(),
                        NangLucLamViec = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IDUser)
                .ForeignKey("dbo.ChucVu", t => t.IDChucVu)
                .Index(t => t.IDChucVu);
            
            CreateTable(
                "dbo.DoUong",
                c => new
                    {
                        IDDoUong = c.String(nullable: false, maxLength: 10),
                        TenDoUong = c.String(),
                        LoaiDoUong = c.String(),
                        GiaTien = c.Int(nullable: false),
                        KhuyenMai = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IDDoUong);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ThongTinCaNhan", "IDChucVu", "dbo.ChucVu");
            DropIndex("dbo.ThongTinCaNhan", new[] { "IDChucVu" });
            DropTable("dbo.DoUong");
            DropTable("dbo.ThongTinCaNhan");
            DropTable("dbo.ChucVu");
        }
    }
}
