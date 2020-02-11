namespace EF_CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        ClientId = c.Int(nullable: false, identity: true),
                        Company_Name = c.String(),
                        Street = c.String(),
                        ZipCode = c.String(),
                        City = c.String(),
                        Adress = c.String(),
                        Email = c.String(),
                        Number = c.String(),
                        Language = c.String(),
                        Project_ProjectId = c.Int(),
                    })
                .PrimaryKey(t => t.ClientId)
                .ForeignKey("dbo.Projects", t => t.Project_ProjectId)
                .Index(t => t.Project_ProjectId);
            
            CreateTable(
                "dbo.Projects",
                c => new
                    {
                        ProjectId = c.Int(nullable: false, identity: true),
                        SignatureDate = c.DateTime(nullable: false),
                        ProjectNumber = c.String(),
                        ProjectLeader = c.String(),
                        Statut = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProjectId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Clients", "Project_ProjectId", "dbo.Projects");
            DropIndex("dbo.Clients", new[] { "Project_ProjectId" });
            DropTable("dbo.Projects");
            DropTable("dbo.Clients");
        }
    }
}
