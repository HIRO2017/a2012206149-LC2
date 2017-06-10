namespace a12206149_PER.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migraacion3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Administrativoes", "sexo", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Administrativoes", "sexo");
        }
    }
}
