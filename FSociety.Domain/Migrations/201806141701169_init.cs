namespace FSociety.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Novels",
                c => new
                    {
                        NovelID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Сontent = c.String(),
                    })
                .PrimaryKey(t => t.NovelID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Novels");
        }
    }
}
