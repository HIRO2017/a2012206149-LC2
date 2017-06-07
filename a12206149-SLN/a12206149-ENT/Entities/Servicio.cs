using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a12206149_ENT.Entities
{
    public class Servicio
    {
        public int servicioId { get; set; }

        public string  transporteServicio { get; set; }

        public string tipoEncomiendaServicio { get; set; }

        public string destinoServicio { get; set; }

        public DateTime fechaSalida { get; set; }
    }
}
