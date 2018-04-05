namespace BlogdoGabrielMoraes.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Update : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Posts", "DateUpdated", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Posts", "DateUpdated", c => c.DateTime(nullable: false));
        }
    }
}
