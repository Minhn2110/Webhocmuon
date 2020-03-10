namespace webhocmuon.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class tble : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RollNumber = c.String(),
                        PenaltyOption = c.Int(nullable: false),
                        Amount = c.Double(nullable: false),
                        CurrentDateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Students");
        }
    }
}
