﻿using a12206149_ENT.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a12206149_PER.EntityTypeConfiguration
{
    public class EmpleadoConfiguration : EntityTypeConfiguration<Empleado>
    {
        public EmpleadoConfiguration()
        {
            //Table configurations
            ToTable("Empleado");
            HasKey(c => c.empleadoId
            );
            //Property(c => c.Placa).IsRequired().HasMaxLength(15);

            //Relationships Configurations

        }
    }
}
