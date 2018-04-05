namespace BlogdoGabrielMoraes.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AttEditNew : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Posts", "PostingBody", c => c.String(nullable: false, maxLength: 3000));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Posts", "PostingBody", c => c.String(nullable: false));
        }
    }
}
