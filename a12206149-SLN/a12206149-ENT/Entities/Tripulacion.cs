using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a12206149_ENT.ENT.Entities
{
    public class Tripulacion : Empleado
    {
        public TipoTripulacion TipoTripulacion { get; set; }

        public Tripulacion()
        {
            TipoTripulacion = new TipoTripulacion();
        }
    }
}
