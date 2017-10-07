namespace ServerCafe.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ThongTinCaNhan", "IDChucVu", "dbo.ChucVu");
            DropIndex("dbo.ThongTinCaNhan", new[] { "IDChucVu" });
            DropPrimaryKey("dbo.ChucVu");
            DropPrimaryKey("dbo.ThongTinCaNhan");
            DropPrimaryKey("dbo.DoUong");
            AlterColumn("dbo.ChucVu", "IDChucVu", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.ThongTinCaNhan", "IDUser", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.ThongTinCaNhan", "IDChucVu", c => c.String(maxLength: 128));
            AlterColumn("dbo.DoUong", "IDDoUong", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.ChucVu", "IDChucVu");
            AddPrimaryKey("dbo.ThongTinCaNhan", "IDUser");
            AddPrimaryKey("dbo.DoUong", "IDDoUong");
            CreateIndex("dbo.ThongTinCaNhan", "IDChucVu");
            AddForeignKey("dbo.ThongTinCaNhan", "IDChucVu", "dbo.ChucVu", "IDChucVu");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ThongTinCaNhan", "IDChucVu", "dbo.ChucVu");
            DropIndex("dbo.ThongTinCaNhan", new[] { "IDChucVu" });
            DropPrimaryKey("dbo.DoUong");
            DropPrimaryKey("dbo.ThongTinCaNhan");
            DropPrimaryKey("dbo.ChucVu");
            AlterColumn("dbo.DoUong", "IDDoUong", c => c.String(nullable: false, maxLength: 10));
            AlterColumn("dbo.ThongTinCaNhan", "IDChucVu", c => c.String(maxLength: 10));
            AlterColumn("dbo.ThongTinCaNhan", "IDUser", c => c.String(nullable: false, maxLength: 10));
            AlterColumn("dbo.ChucVu", "IDChucVu", c => c.String(nullable: false, maxLength: 10));
            AddPrimaryKey("dbo.DoUong", "IDDoUong");
            AddPrimaryKey("dbo.ThongTinCaNhan", "IDUser");
            AddPrimaryKey("dbo.ChucVu", "IDChucVu");
            CreateIndex("dbo.ThongTinCaNhan", "IDChucVu");
            AddForeignKey("dbo.ThongTinCaNhan", "IDChucVu", "dbo.ChucVu", "IDChucVu");
        }
    }
}
