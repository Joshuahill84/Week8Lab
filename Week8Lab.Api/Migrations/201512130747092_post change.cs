namespace Week8Lab.Api.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class postchange : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Posts", "Text", c => c.String());
            AddColumn("dbo.Posts", "user_Id", c => c.Int());
            CreateIndex("dbo.Posts", "user_Id");
            AddForeignKey("dbo.Posts", "user_Id", "dbo.users", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Posts", "user_Id", "dbo.users");
            DropIndex("dbo.Posts", new[] { "user_Id" });
            DropColumn("dbo.Posts", "user_Id");
            DropColumn("dbo.Posts", "Text");
            DropTable("dbo.users");
        }
    }
}
