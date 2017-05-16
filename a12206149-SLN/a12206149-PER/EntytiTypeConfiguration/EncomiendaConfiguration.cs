using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a12206149_PER.EntytiTypeConfiguration
{
    public class EncomiendaConfiguration
    {
        LugarViajeConfiguration lug = new LugarViajeConfiguration();

        class LugarViajeConfiguration
        {
            public string Nombrelugarviaje { get; set; }
            
        }
    }
}
