namespace a12206149_PER.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Ventas", "descripcion", c => c.String());
            AddColumn("dbo.Ventas", "nombreEmpleado", c => c.String());
            DropColumn("dbo.Ventas", "nombreCliente");
            DropColumn("dbo.Ventas", "nombreAdministrativo");
            DropColumn("dbo.Ventas", "nombretipoComprobante");
            DropColumn("dbo.Ventas", "nombreSerivio");
            DropColumn("dbo.Ventas", "nombreTipoPago");
            DropTable("dbo.Clientes");
            DropTable("dbo.Empleadoes");
            DropTable("dbo.Encomiendas");
            DropTable("dbo.LugarViajes");
            DropTable("dbo.Servicios");
            DropTable("dbo.TipoComprobantes");
            DropTable("dbo.TipoLugars");
            DropTable("dbo.TipoPagoes");
            DropTable("dbo.TipoTripulacions");
            DropTable("dbo.TipoViajes");
            DropTable("dbo.Transportes");
            DropTable("dbo.Tripulacions");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Tripulacions",
                c => new
                    {
                        tripulacionId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.tripulacionId);
            
            CreateTable(
                "dbo.Transportes",
                c => new
                    {
                        transporteId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.transporteId);
            
            CreateTable(
                "dbo.TipoViajes",
                c => new
                    {
                        tipoViajeId = c.Int(nullable: false, identity: true),
                        transporteViaje = c.String(),
                        nombreTipoViaje = c.String(),
                    })
                .PrimaryKey(t => t.tipoViajeId);
            
            CreateTable(
                "dbo.TipoTripulacions",
                c => new
                    {
                        TipoTripulacionId = c.Int(nullable: false, identity: true),
                        nombre = c.String(),
                    })
                .PrimaryKey(t => t.TipoTripulacionId);
            
            CreateTable(
                "dbo.TipoPagoes",
                c => new
                    {
                        tipoPagoId = c.Int(nullable: false, identity: true),
                        nombreTipoPago = c.String(),
                    })
                .PrimaryKey(t => t.tipoPagoId);
            
            CreateTable(
                "dbo.TipoLugars",
                c => new
                    {
                        tipoLugarId = c.Int(nullable: false, identity: true),
                        tipoLugar = c.String(),
                    })
                .PrimaryKey(t => t.tipoLugarId);
            
            CreateTable(
                "dbo.TipoComprobantes",
                c => new
                    {
                        tipoComprobanteId = c.Int(nullable: false, identity: true),
                        nombreComprobante = c.String(),
                    })
                .PrimaryKey(t => t.tipoComprobanteId);
            
            CreateTable(
                "dbo.Servicios",
                c => new
                    {
                        servicioId = c.Int(nullable: false, identity: true),
                        transporteServicio = c.String(),
                        tipoEncomiendaServicio = c.String(),
                        destinoServicio = c.String(),
                        fechaSalida = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.servicioId);
            
            CreateTable(
                "dbo.LugarViajes",
                c => new
                    {
                        lugarViajeId = c.Int(nullable: false, identity: true),
                        nombre = c.String(),
                    })
                .PrimaryKey(t => t.lugarViajeId);
            
            CreateTable(
                "dbo.Encomiendas",
                c => new
                    {
                        encomiendaId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.encomiendaId);
            
            CreateTable(
                "dbo.Empleadoes",
                c => new
                    {
                        empleadoId = c.Int(nullable: false, identity: true),
                        nombre = c.String(),
                        apellidos = c.String(),
                        direccion = c.String(),
                        celular = c.Int(nullable: false),
                        lugarNacimiento = c.String(),
                    })
                .PrimaryKey(t => t.empleadoId);
            
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        clienteId = c.Int(nullable: false, identity: true),
                        nombre = c.String(),
                        apellidos = c.String(),
                        direccion = c.String(),
                        celular = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.clienteId);
            
            AddColumn("dbo.Ventas", "nombreTipoPago", c => c.String());
            AddColumn("dbo.Ventas", "nombreSerivio", c => c.String());
            AddColumn("dbo.Ventas", "nombretipoComprobante", c => c.String());
            AddColumn("dbo.Ventas", "nombreAdministrativo", c => c.String());
            AddColumn("dbo.Ventas", "nombreCliente", c => c.String());
            DropColumn("dbo.Ventas", "nombreEmpleado");
            DropColumn("dbo.Ventas", "descripcion");
        }
    }
}
