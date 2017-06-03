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
    }
}
