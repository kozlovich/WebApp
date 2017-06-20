namespace WebApp.EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUsers : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                        Password = c.String(),
                        Email = c.String(),
                        IsActive = c.String(),
                        UserType_UserTypeId = c.Int(),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.UserTypes", t => t.UserType_UserTypeId)
                .Index(t => t.UserType_UserTypeId);
            
            CreateTable(
                "dbo.UserTypes",
                c => new
                    {
                        UserTypeId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.UserTypeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "UserType_UserTypeId", "dbo.UserTypes");
            DropIndex("dbo.Users", new[] { "UserType_UserTypeId" });
            DropTable("dbo.UserTypes");
            DropTable("dbo.Users");
        }
    }
}
