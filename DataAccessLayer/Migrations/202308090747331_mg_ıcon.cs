namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mg_ıcon : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SocialMedias", "Icon", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.SocialMedias", "Icon");
        }
    }
}
