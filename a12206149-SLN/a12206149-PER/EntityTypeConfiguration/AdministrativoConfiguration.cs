using a12206149_ENT.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a12206149_PER.EntityTypeConfiguration
{
    public class AdministrativoConfiguration : EntityTypeConfiguration<Administrativo>
    {

        public AdministrativoConfiguration()
        {
            //Table configurations
            ToTable("ADMINISTRATIVO");
            HasKey(c => c.administrativoId);
            Property(c => c.apellidos).IsRequired().HasMaxLength(15);

            //Relationships Configurations;

        }
    }
}
