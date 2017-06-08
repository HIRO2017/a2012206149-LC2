using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a12206149_ENT.IRepositories
{
    public interface IUnityOfWork :  IDisposable
    {
        IEmpleadoRepository Empleados { get; }
        IAdministrativoRepository Administrativos { get; }
        IBusRepository Buses { get; }
        IEncomiendaRepository Encomiendas { get; }
        ILugarViajeRepository LugarViajes { get; }
        IServicioRepository Servicios { get; }
        ITipoComprobanteRepository TipoComprobantes { get; }
        ITipoLugarRepository TipoLugares { get; }
        ITipoPagoRepository TipoPagos { get; }
        ITipoTripulacionRepository TipoTripulaciones { get; }
        ITipoViajeRepository TipoViajes { get; }
        ITransporteRepository Transportes { get; }
        ITripulacionRepository Tripulacioness { get; }
        IVentaRepository Ventas { get; }
        IClienteRepository Clientes { get; }



        int SaveChanges();
    }
}
