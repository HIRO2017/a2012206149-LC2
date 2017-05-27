﻿using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a12206149_PER.EntytiTypeConfiguration
{
    public class TipoTripulacionConfiguration : EntityTypeConfiguration<TipoTripulacionConfiguration>
    {
        public TipoTripulacionConfiguration()
        {
            ToTable("Tipo Tripulacion");
            HasKey(c => c.TipoTripulacionId);

        }
    }
}
