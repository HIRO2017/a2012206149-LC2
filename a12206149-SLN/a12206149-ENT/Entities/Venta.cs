using a12206149_ENT.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a12206149_ENT.Entities
{
    public class Venta
    {
        public int VentaId { get; set; }
        public DateTime Fecha { get; set; }

        public ICollection<Administrativo> Administrativo { get; set; }
        public ICollection<Cliente> Cliente { get; set; }
        public ICollection<Servicio> Servicio { get; set; }
        public TipoPago TipoPago { get; set; }
        public TipoComprobante TipoComprobante { get; set; }
        public Venta()
        {
            Administrativo = new List<Administrativo>();
            Cliente = new List<Cliente>();
            Servicio = new List<Servicio>();

        }

    }
}
