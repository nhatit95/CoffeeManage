namespace ServerCafe.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial3 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LoaiDoUong",
                c => new
                    {
                        IDLoaiDoUong = c.String(nullable: false, maxLength: 128),
                        TenLoaiDoUong = c.String(),
                    })
                .PrimaryKey(t => t.IDLoaiDoUong);
            
            CreateTable(
                "dbo.NguyenLieu",
                c => new
                    {
                        IDNguyenLieu = c.String(nullable: false, maxLength: 128),
                        TenNguyenLieu = c.String(),
                        DonViTinh = c.String(),
                        Gia = c.Int(nullable: false),
                        SoLuong = c.Int(nullable: false),
                        DoUong_IDDoUong = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.IDNguyenLieu)
                .ForeignKey("dbo.DoUong", t => t.DoUong_IDDoUong)
                .Index(t => t.DoUong_IDDoUong);
            
            CreateTable(
                "dbo.NoiIn",
                c => new
                    {
                        IDNoiIn = c.String(nullable: false, maxLength: 128),
                        TenNoiIn = c.String(),
                    })
                .PrimaryKey(t => t.IDNoiIn);
            
            AddColumn("dbo.DoUong", "IDLoaiDoUong", c => c.String(maxLength: 128));
            AddColumn("dbo.DoUong", "IDNoiIn", c => c.String(maxLength: 128));
            CreateIndex("dbo.DoUong", "IDLoaiDoUong");
            CreateIndex("dbo.DoUong", "IDNoiIn");
            AddForeignKey("dbo.DoUong", "IDLoaiDoUong", "dbo.LoaiDoUong", "IDLoaiDoUong");
            AddForeignKey("dbo.DoUong", "IDNoiIn", "dbo.NoiIn", "IDNoiIn");
            DropColumn("dbo.DoUong", "LoaiDoUong");
        }
        
        public override void Down()
        {
            AddColumn("dbo.DoUong", "LoaiDoUong", c => c.String());
            DropForeignKey("dbo.DoUong", "IDNoiIn", "dbo.NoiIn");
            DropForeignKey("dbo.NguyenLieu", "DoUong_IDDoUong", "dbo.DoUong");
            DropForeignKey("dbo.DoUong", "IDLoaiDoUong", "dbo.LoaiDoUong");
            DropIndex("dbo.NguyenLieu", new[] { "DoUong_IDDoUong" });
            DropIndex("dbo.DoUong", new[] { "IDNoiIn" });
            DropIndex("dbo.DoUong", new[] { "IDLoaiDoUong" });
            DropColumn("dbo.DoUong", "IDNoiIn");
            DropColumn("dbo.DoUong", "IDLoaiDoUong");
            DropTable("dbo.NoiIn");
            DropTable("dbo.NguyenLieu");
            DropTable("dbo.LoaiDoUong");
        }
    }
}
