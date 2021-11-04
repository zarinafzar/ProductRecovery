namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mighj : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.PompsEvents", "StopDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.PompsEvents", "StopDate", c => c.DateTime(nullable: false));
        }
    }
}
