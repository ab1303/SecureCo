namespace SecureCo.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SecureCoDatabaseSetup : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cheque",
                c => new
                    {
                        ChequeId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 50),
                        LastName = c.String(nullable: false, maxLength: 50),
                        Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DateCreated = c.DateTime(nullable: false),
                        DateChanged = c.DateTime(),
                        CreateLogin = c.String(nullable: false, maxLength: 100),
                        UpdateLogin = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.ChequeId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Cheque");
        }
    }
}
