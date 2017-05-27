using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a12206149_ENT.ENT.Entities
{
    public class Tripulacion : Empleado
    {
        public int Tipo { get; set; }
        
        //TipoTripolucion
        public int TipoTripulacionId { get; set; }
        public TipoTripulacion TipoTripulacion { get; set; }

        



    }
}
