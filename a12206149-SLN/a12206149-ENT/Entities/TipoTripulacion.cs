using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a12206149_ENT.ENT.Entities
{
    public class TipoTripulacion
    {

        public int TipoTripulacionId { get; set; }

         //Tripulacion
        public int TripulacionId { get; set; }
        public List<Tripulacion> Tripoulaciones { get; set; }

        public TipoTripulacion()
        {
            Tripoulaciones = new List<Tripulacion>();
        }
       

    }
}
