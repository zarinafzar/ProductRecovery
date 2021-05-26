namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class pompeventsinit : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PompsEvents",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PompId = c.Int(nullable: false),
                        StartDate = c.DateTime(nullable: false),
                        StopDate = c.DateTime(nullable: false),
                        IsStart = c.Boolean(nullable: false),
                        Descriptions = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Pomps", t => t.PompId, cascadeDelete: true)
                .Index(t => t.PompId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PompsEvents", "PompId", "dbo.Pomps");
            DropIndex("dbo.PompsEvents", new[] { "PompId" });
            DropTable("dbo.PompsEvents");
        }
    }
}
