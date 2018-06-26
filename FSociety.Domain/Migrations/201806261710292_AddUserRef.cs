namespace FSociety.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUserRef : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Novels", "UserID", c => c.String(maxLength: 128));
            CreateIndex("dbo.Novels", "UserID");
            AddForeignKey("dbo.Novels", "UserID", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Novels", "UserID", "dbo.AspNetUsers");
            DropIndex("dbo.Novels", new[] { "UserID" });
            DropColumn("dbo.Novels", "UserID");
        }
    }
}
