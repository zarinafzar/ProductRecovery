namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class pupmMinten : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.PompsEvents", "StopDate", c => c.DateTime(nullable: false));
            DropColumn("dbo.Pomps", "UnderMaintenance");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Pomps", "UnderMaintenance", c => c.Boolean(nullable: false));
            AlterColumn("dbo.PompsEvents", "StopDate", c => c.DateTime());
        }
    }
}
