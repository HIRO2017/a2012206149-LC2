using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a12206149_ENT.Entities
{
    public class Administrativo : Empleado
    {

        public string Cargo { get; set; }

        public int VentaId { get; set; }
        public Venta Venta { get; set; }

    }
}
