using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a12206149_ENT.ENT.Entities
{
    public class Venta
    {
        public Administrativo Administrativo { get; set; }
        public Cliente Cliente { get; set; }
        public TipoComprobante TipoComprobante { get; set; }
        public TipoPago TipoPago { get; set; }
        public Servicio Servicio { get; set; }

        public Venta()
        {
            Administrativo = new Administrativo();
            Cliente = new Cliente();
            TipoComprobante = new TipoComprobante();
            TipoPago = new TipoPago();
            Servicio = new Servicio();
        }
    }
}
