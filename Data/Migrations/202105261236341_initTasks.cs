namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initTasks : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RuntimeTasks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UnitId = c.Int(nullable: false),
                        Subject = c.String(maxLength: 50),
                        Description = c.String(),
                        Person = c.String(maxLength: 50),
                        ControllerPerson = c.String(maxLength: 50),
                        StartDate = c.DateTime(nullable: false),
                        FinishDate = c.DateTime(nullable: false),
                        DeleveryDays = c.Int(nullable: false),
                        IsFinish = c.Boolean(nullable: false),
                        IsCancel = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Units", t => t.UnitId, cascadeDelete: true)
                .Index(t => t.UnitId);
            
            AddColumn("dbo.Pomps", "OutOfReach", c => c.Boolean(nullable: false));
            AddColumn("dbo.Pomps", "UnderMaintenance", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RuntimeTasks", "UnitId", "dbo.Units");
            DropIndex("dbo.RuntimeTasks", new[] { "UnitId" });
            DropColumn("dbo.Pomps", "UnderMaintenance");
            DropColumn("dbo.Pomps", "OutOfReach");
            DropTable("dbo.RuntimeTasks");
        }
    }
}
