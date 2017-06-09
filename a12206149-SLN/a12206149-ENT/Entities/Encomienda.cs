using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a12206149_ENT.Entities
{
    public class Encomienda : Servicio
    {

        public string AsuntoEncomienda { get; set; }
        public double Peso { get; set; }
        public string NombreDestinatario { get; set; }

        public int BusId { get; set; }
        public Bus Bus { get; set; }

        public ICollection<LugarViaje> LugarViaje { get; set; }

        public Encomienda()
        {
            LugarViaje = new List<LugarViaje>();
        }
    }
}
