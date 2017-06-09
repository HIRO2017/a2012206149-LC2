namespace a12206149_PER.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMode : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Encomiendas", newName: "Servicios");
            DropPrimaryKey("dbo.Servicios");
            CreateTable(
                "dbo.Buses",
                c => new
                    {
                        BusId = c.Int(nullable: false, identity: true),
                        Placa = c.String(),
                        SerieMotor = c.String(),
                    })
                .PrimaryKey(t => t.BusId);
            
            AddColumn("dbo.Clientes", "DNI", c => c.String());
            AddColumn("dbo.Empleadoes", "Discriminator", c => c.String(nullable: false, maxLength: 128));
            AddColumn("dbo.Servicios", "servicioId", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Servicios", "nombre", c => c.Int(nullable: false));
            AddColumn("dbo.Servicios", "Discriminator", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Servicios", "servicioId");
            DropColumn("dbo.Clientes", "direccion");
            DropColumn("dbo.Clientes", "celular");
            DropColumn("dbo.Empleadoes", "apellidos");
            DropColumn("dbo.Empleadoes", "celular");
            DropColumn("dbo.Empleadoes", "lugarNacimiento");
            DropColumn("dbo.Servicios", "encomiendaId");
            DropColumn("dbo.LugarViajes", "nombre");
            DropColumn("dbo.TipoComprobantes", "nombreComprobante");
            DropColumn("dbo.TipoLugars", "tipoLugar");
            DropColumn("dbo.TipoPagoes", "nombreTipoPago");
            DropColumn("dbo.TipoTripulacions", "nombre");
            DropColumn("dbo.TipoViajes", "transporteViaje");
            DropColumn("dbo.TipoViajes", "nombreTipoViaje");
            DropColumn("dbo.Ventas", "nombreCliente");
            DropColumn("dbo.Ventas", "nombreAdministrativo");
            DropColumn("dbo.Ventas", "nombretipoComprobante");
            DropColumn("dbo.Ventas", "nombreSerivio");
            DropColumn("dbo.Ventas", "nombreTipoPago");
            DropTable("dbo.Servicios");
            DropTable("dbo.Transportes");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Transportes",
                c => new
                    {
                        transporteId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.transporteId);
            
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
            
            AddColumn("dbo.Ventas", "nombreTipoPago", c => c.String());
            AddColumn("dbo.Ventas", "nombreSerivio", c => c.String());
            AddColumn("dbo.Ventas", "nombretipoComprobante", c => c.String());
            AddColumn("dbo.Ventas", "nombreAdministrativo", c => c.String());
            AddColumn("dbo.Ventas", "nombreCliente", c => c.String());
            AddColumn("dbo.TipoViajes", "nombreTipoViaje", c => c.String());
            AddColumn("dbo.TipoViajes", "transporteViaje", c => c.String());
            AddColumn("dbo.TipoTripulacions", "nombre", c => c.String());
            AddColumn("dbo.TipoPagoes", "nombreTipoPago", c => c.String());
            AddColumn("dbo.TipoLugars", "tipoLugar", c => c.String());
            AddColumn("dbo.TipoComprobantes", "nombreComprobante", c => c.String());
            AddColumn("dbo.LugarViajes", "nombre", c => c.String());
            AddColumn("dbo.Servicios", "encomiendaId", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Empleadoes", "lugarNacimiento", c => c.String());
            AddColumn("dbo.Empleadoes", "celular", c => c.Int(nullable: false));
            AddColumn("dbo.Empleadoes", "apellidos", c => c.String());
            AddColumn("dbo.Clientes", "celular", c => c.Int(nullable: false));
            AddColumn("dbo.Clientes", "direccion", c => c.String());
            DropPrimaryKey("dbo.Servicios");
            DropColumn("dbo.Servicios", "Discriminator");
            DropColumn("dbo.Servicios", "nombre");
            DropColumn("dbo.Servicios", "servicioId");
            DropColumn("dbo.Empleadoes", "Discriminator");
            DropColumn("dbo.Clientes", "DNI");
            DropTable("dbo.Buses");
            AddPrimaryKey("dbo.Servicios", "encomiendaId");
            RenameTable(name: "dbo.Servicios", newName: "Encomiendas");
        }
    }
}
