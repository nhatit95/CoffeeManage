namespace ServerCafe.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial11 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.DonVi",
                c => new
                    {
                        IDDonVi = c.String(nullable: false, maxLength: 128),
                        TenDonVi = c.String(),
                    })
                .PrimaryKey(t => t.IDDonVi);
            
            AddColumn("dbo.NguyenLieu", "IDDonVi", c => c.String(maxLength: 128));
            CreateIndex("dbo.NguyenLieu", "IDDonVi");
            AddForeignKey("dbo.NguyenLieu", "IDDonVi", "dbo.DonVi", "IDDonVi");
            DropColumn("dbo.NguyenLieu", "DonViTinh");
        }
        
        public override void Down()
        {
            AddColumn("dbo.NguyenLieu", "DonViTinh", c => c.String());
            DropForeignKey("dbo.NguyenLieu", "IDDonVi", "dbo.DonVi");
            DropIndex("dbo.NguyenLieu", new[] { "IDDonVi" });
            DropColumn("dbo.NguyenLieu", "IDDonVi");
            DropTable("dbo.DonVi");
        }
    }
}
