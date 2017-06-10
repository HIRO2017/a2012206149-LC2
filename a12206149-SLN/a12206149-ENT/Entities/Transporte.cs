using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a12206149_ENT.Entities
{
    public class Transporte
    {
        public int transporteId { get; set; }
        public string nombre { get; set; }
        public int capacidad { get; set; }
        public string destino { get; set; }
    }
}
