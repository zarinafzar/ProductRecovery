namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class pompinit : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Pomps",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PompName = c.String(maxLength: 50),
                        PompType = c.String(maxLength: 50),
                        Remark = c.String(),
                        IsDelete = c.Boolean(nullable: false),
                        CatId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.CatId, cascadeDelete: true)
                .Index(t => t.CatId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Pomps", "CatId", "dbo.Categories");
            DropIndex("dbo.Pomps", new[] { "CatId" });
            DropTable("dbo.Pomps");
        }
    }
}
