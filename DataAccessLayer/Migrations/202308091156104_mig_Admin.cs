namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig_Admin : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Admins");
            AlterColumn("dbo.Admins", "ID", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Admins", "ID");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Admins");
            AlterColumn("dbo.Admins", "ID", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Admins", "ID");
        }
    }
}
