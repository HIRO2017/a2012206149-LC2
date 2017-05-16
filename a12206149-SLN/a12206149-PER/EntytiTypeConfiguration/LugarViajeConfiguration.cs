using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a12206149_PER.EntytiTypeConfiguration
{
    public class LugarViajeConfiguration : EntityTypeConfiguration<LugarViajeConfiguration>
    {
        TipoLugarConfiguration tiplug = new TipoLugarConfiguration();

        class TipoLugarConfiguration
        {
            public string NombreLugar { get; set; }
            public int LugarCodigo { get; set; }
        }
    }
}
