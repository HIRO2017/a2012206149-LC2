using a12206149_ENT;
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
        public DbSet<Venta> Ventas { get; set; }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Administrativo> Administrativos { get; set; }
        public DbSet<Bus> Buses { get; set; }
        public DbSet<Encomienda> Encomiendas { get; set; }
        public DbSet<Servicio> Servicios { get; set; }
        public DbSet<Transporte> Transportes { get; set; }
        public DbSet<Tripulacion> Tripulaciones { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
    }
}
    