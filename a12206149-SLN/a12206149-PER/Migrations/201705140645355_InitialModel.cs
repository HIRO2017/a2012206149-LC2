namespace a12206149_PER.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Administrativoes",
                c => new
                    {
                        AdministrativoId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.AdministrativoId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Administrativoes");
        }
    }
}
