﻿using a12206149_ENT;
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
    }
}
    