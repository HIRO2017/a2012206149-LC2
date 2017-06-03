using a12206149_ENT.ENT.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a12206149_PER
{
    public class a12206149DbContext : DbContext
    {
        public DbSet<Administrativo> Administrativo { get; set; }

        public System.Data.Entity.DbSet<a12206149_ENT.ENT.Entities.Empleado> Empleadoes { get; set; }

        public System.Data.Entity.DbSet<a12206149_ENT.ENT.Entities.Servicio> Servicios { get; set; }

        public System.Data.Entity.DbSet<a12206149_ENT.ENT.Entities.Venta> Ventas { get; set; }

        public System.Data.Entity.DbSet<a12206149_ENT.ENT.Entities.Transporte> Transportes { get; set; }

        public System.Data.Entity.DbSet<a12206149_ENT.ENT.Entities.TipoTripulacion> TipoTripulacions { get; set; }

        public System.Data.Entity.DbSet<a12206149_ENT.ENT.Entities.TipoPago> TipoPagoes { get; set; }

        public System.Data.Entity.DbSet<a12206149_ENT.ENT.Entities.TipoLugar> TipoLugars { get; set; }

        public System.Data.Entity.DbSet<a12206149_ENT.ENT.Entities.LugarViaje> LugarViajes { get; set; }

        public System.Data.Entity.DbSet<a12206149_ENT.ENT.Entities.Encomienda> Encomiendas { get; set; }

        public System.Data.Entity.DbSet<a12206149_ENT.ENT.Entities.Cliente> Clientes { get; set; }

        public System.Data.Entity.DbSet<a12206149_ENT.ENT.Entities.Bus> Buses { get; set; }
    }
}
