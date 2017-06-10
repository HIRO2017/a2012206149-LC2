using a12206149_ENT;
using a12206149_ENT.Entities;
using a12206149_PER.EntityTypeConfiguration;
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




        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new AdministrativoConfiguration());
            modelBuilder.Configurations.Add(new BusConfiguration());
            modelBuilder.Configurations.Add(new ClienteConfiguration());
            modelBuilder.Configurations.Add(new EmpleadoConfiguration());
            modelBuilder.Configurations.Add(new EncomiendaConfiguration());
            modelBuilder.Configurations.Add(new ServicioConfiguration());
            modelBuilder.Configurations.Add(new TransporteConfiguration());
            modelBuilder.Configurations.Add(new TripulacionConfiguration());
            modelBuilder.Configurations.Add(new VentasConfiguration());


            base.OnModelCreating(modelBuilder);
        }
    }
}
    