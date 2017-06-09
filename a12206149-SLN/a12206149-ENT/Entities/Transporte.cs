using a12206149_ENT.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a12206149_ENT.Entities
{
    public class Transporte : Servicio
    {
        public ICollection<Cliente> Cliente { get; set; }
        public TipoViaje TipoViaje { get; set; }
        public ICollection<Administrativo> Bus { get; set; }
        public ICollection<LugarViaje> LugarViaje { get; set; }

        public Transporte()
        {
            Cliente = new List<Cliente>();
            Bus = new List<Administrativo>();
            LugarViaje = new List<LugarViaje>();
        }
    }
}
