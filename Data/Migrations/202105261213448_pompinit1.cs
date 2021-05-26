namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class pompinit1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Pomps", "InWorkDuration", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Pomps", "InWorkDuration");
        }
    }
}
