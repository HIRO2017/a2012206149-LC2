namespace a12206149_PER.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class agregarempleado : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Empleadoes",
                c => new
                    {
                        empleadoId = c.Int(nullable: false, identity: true),
                        nombre = c.String(),
                        apellidos = c.String(),
                        direccion = c.String(),
                        celular = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.empleadoId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Empleadoes");
        }
    }
}
