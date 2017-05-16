using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a12206149_PER.EntytiTypeConfiguration
{
    public class TransporteConfiguration
    {
        LugarViajeConfiguration lug = new LugarViajeConfiguration();

        class LugarViajeConfiguration
        {
            public string Nombrelugarviaje { get; set; }

        }

        TipoViajeConfiguration tipViaje = new TipoViajeConfiguration();

        class TipoViajeConfiguration
        {
            public string Nombrelugarviaje { get; set; }

        }


        ClienteConfiguration Cliente = new ClienteConfiguration();

        class ClienteConfiguration
        {
            public string Nombrelugarviaje { get; set; }

        }
    }
}
