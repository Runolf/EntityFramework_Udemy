namespace EF_CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddUsersTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UsersId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.UsersId);

            Sql("INSERT INTO Users VALUES('Runolf')");
            Sql("INSERT INTO Users VALUES('Asbjorn')");


        }

        public override void Down()
        {
            DropTable("dbo.Users");
        }
    }
}
