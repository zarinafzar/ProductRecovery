namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initCategories : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CatName = c.String(maxLength: 50),
                        Remark = c.String(),
                        IsDelete = c.Boolean(nullable: false),
                        UnitId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Units", t => t.UnitId, cascadeDelete: true)
                .Index(t => t.UnitId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Categories", "UnitId", "dbo.Units");
            DropIndex("dbo.Categories", new[] { "UnitId" });
            DropTable("dbo.Categories");
        }
    }
}
