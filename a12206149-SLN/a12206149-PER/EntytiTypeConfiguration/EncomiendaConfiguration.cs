using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a12206149_PER.EntytiTypeConfiguration
{
    public class EncomiendaConfiguration : EntityTypeConfiguration<EncomiendaConfiguration>
    {
        LugarViajeConfiguration lug = new LugarViajeConfiguration();

        class LugarViajeConfiguration
        {
            public string Nombrelugarviaje { get; set; }
            
        }
    }
}
