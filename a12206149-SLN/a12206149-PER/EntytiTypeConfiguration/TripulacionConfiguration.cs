using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a12206149_PER.EntytiTypeConfiguration
{
    public class TripulacionConfiguration : EntityTypeConfiguration<TripulacionConfiguration>
    {

        TipoTripulacionConfiguration tripu = new TipoTripulacionConfiguration();
   
        class TipoTripulacionConfiguration
        {
            public int Name { get; set; }
            public int NumeroTripulacion { get; set; }
        }

    








    }
}
