namespace a12206149_PER.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mvc : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Administrativoes",
                c => new
                    {
                        administrativoId = c.Int(nullable: false, identity: true),
                        nombre = c.String(),
                        apellidos = c.String(),
                        celular = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.administrativoId);
            
            CreateTable(
                "dbo.Buses",
                c => new
                    {
                        busId = c.Int(nullable: false, identity: true),
                        descripcion = c.String(),
                        destigno = c.String(),
                        capacidad = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.busId);
            
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        clienteId = c.Int(nullable: false, identity: true),
                        nombre = c.String(),
                        apellido = c.String(),
                        direccion = c.String(),
                        dni = c.Int(nullable: false),
                        celular = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.clienteId);
            
            CreateTable(
                "dbo.Encomiendas",
                c => new
                    {
                        encomiendaId = c.Int(nullable: false, identity: true),
                        destino = c.String(),
                    })
                .PrimaryKey(t => t.encomiendaId);
            
            CreateTable(
                "dbo.Servicios",
                c => new
                    {
                        servicioId = c.Int(nullable: false, identity: true),
                        nombreServicio = c.String(),
                        tipo = c.String(),
                    })
                .PrimaryKey(t => t.servicioId);
            
            CreateTable(
                "dbo.Transportes",
                c => new
                    {
                        transporteId = c.Int(nullable: false, identity: true),
                        nombre = c.String(),
                        capacidad = c.Int(nullable: false),
                        destino = c.String(),
                    })
                .PrimaryKey(t => t.transporteId);
            
            CreateTable(
                "dbo.Tripulacions",
                c => new
                    {
                        tripulacionId = c.Int(nullable: false, identity: true),
                        nombre = c.String(),
                        tipo = c.String(),
                    })
                .PrimaryKey(t => t.tripulacionId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Tripulacions");
            DropTable("dbo.Transportes");
            DropTable("dbo.Servicios");
            DropTable("dbo.Encomiendas");
            DropTable("dbo.Clientes");
            DropTable("dbo.Buses");
            DropTable("dbo.Administrativoes");
        }
    }
}
