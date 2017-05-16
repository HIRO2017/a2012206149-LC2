using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a12206149_PER.EntytiTypeConfiguration
{
    public class BusConfiguration
    {

    }

    public class EncomiendaConfiguration
    {
        public BusConfiguration Bus { get; set; }

        public EncomiendaConfiguration()
        {

        }

        public EncomiendaConfiguration(BusConfiguration bus)
        {
            Bus = bus;
        }


    }
}
