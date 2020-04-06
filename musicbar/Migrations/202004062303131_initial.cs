namespace musicbar.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Demoes",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Fname = c.String(),
                        Lname = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Demoes");
        }
    }
}
