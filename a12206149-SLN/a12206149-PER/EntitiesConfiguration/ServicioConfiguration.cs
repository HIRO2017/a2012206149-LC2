using a12206149_ENT.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a12206149_PER.EntitiesConfiguration
{
    public class ServicioConfiguration : EntityTypeConfiguration<Servicio>
    {
        public ServicioConfiguration()
        {
            //Table configurations
            ToTable("Serivicio");
            HasKey(c => c.ServicioId);
            //Property(c => c.Placa).IsRequired().HasMaxLength(15);

            //Relationships Configurations

        }
    }
}
