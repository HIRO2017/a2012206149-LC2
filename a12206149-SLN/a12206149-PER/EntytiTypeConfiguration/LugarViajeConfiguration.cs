using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a12206149_PER.EntytiTypeConfiguration
{
    public class LugarViajeConfiguration
    {
        TipoLugarConfiguration tiplug = new TipoLugarConfiguration();

        class TipoLugarConfiguration
        {
            public string NombreLugar { get; set; }
            public int LugarCodigo { get; set; }
        }
    }
}
