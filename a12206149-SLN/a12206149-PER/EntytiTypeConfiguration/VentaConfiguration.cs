using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a12206149_PER.EntytiTypeConfiguration
{
    public class VentaConfiguration
    {
        AdministrativoConfiguration Administrativo = new AdministrativoConfiguration();

        class AdministrativoConfiguration
        {
            public string Nombrelugarviaje { get; set; }

        }
        ClienteConfiguration Cliente = new ClienteConfiguration();

        class ClienteConfiguration
        {
            public string Nombrelugarviaje { get; set; }

        }
        ServicioConfiguration Servicio = new ServicioConfiguration();

        class ServicioConfiguration
        {
            public string Nombrelugarviaje { get; set; }

        }
        TipoPagoConfiguration TipoPago = new TipoPagoConfiguration();

        class TipoPagoConfiguration
        {
            public string Nombrelugarviaje { get; set; }

        }
        TipoComprobanteConfiguration TipoComp= new TipoComprobanteConfiguration();

        class TipoComprobanteConfiguration
        {
            public string Nombrelugarviaje { get; set; }

        }
        AdministrativoConfiguration Administrativo = new AdministrativoConfiguration();

        class AdministrativoConfiguration
        {
            public string Nombrelugarviaje { get; set; }

        }
    }
}
