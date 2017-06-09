using a12206149_ENT.Entities;
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
        public DbSet<Administrativo> Administrativos { get; set; }
        public DbSet<Bus> Buses { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Encomienda> Encomiendas { get; set; }
        public DbSet<LugarViaje> LugarViajes { get; set; }
        public DbSet<Servicio> Servici{ get; set; }
        public DbSet<TipoComprobante> TipoComprobantes { get; set; }
        public DbSet<TipoLugar> TipoLugares { get; set; }
        public DbSet<TipoPago> TipoPagos { get; set; }
        public DbSet<TipoTripulacion> TipoTripulaciones { get; set; }
        public DbSet<TipoViaje> TipoViajes { get; set; }
        public DbSet<Transporte> Transportess { get; set; }
        public DbSet<Tripulacion> Tripulaciones { get; set; }
        public DbSet<Venta> Ventas { get; set; }

    }
}
