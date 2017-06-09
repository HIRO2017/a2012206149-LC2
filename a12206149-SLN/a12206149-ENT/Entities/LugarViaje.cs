using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a12206149_ENT.Entities
{
    public class LugarViaje
    {
        public int LugarViajeId { get; set; }
        public string NombreLugar { get; set; }

        public int TransporteId { get; set; }
        public Transporte Transporte { get; set; }

        public int EncomiendaId { get; set; }
        public Encomienda Encomienda { get; set; }

        public int BusId { get; set; }
        public Bus Bus { get; set; }

        public TipoTripulacion TipoTripulacion { get; set; }
    }
}
