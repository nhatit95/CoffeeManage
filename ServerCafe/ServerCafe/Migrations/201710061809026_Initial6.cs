namespace ServerCafe.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial6 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.DoUong", "ThanhPhan", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.DoUong", "ThanhPhan");
        }
    }
}
