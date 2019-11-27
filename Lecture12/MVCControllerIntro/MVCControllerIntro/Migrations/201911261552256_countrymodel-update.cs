namespace MVCControllerIntro.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class countrymodelupdate : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Countries", "Name", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Countries", "Name", c => c.String());
        }
    }
}
