using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a12206149_ENT.IRepositories
{
    public interface IUnityOfWork : IDisposable
    {
        IAdministrativoRepository Administrativos { get; }
        IBusRepository Buses { get; }
        IClienteRepository Clientes { get; }
        IEmpleadoRepository Empleados { get; }
        IEncomiendaRepository Encomiendas { get; }
        ILugarViajeRepository LugarViajes { get; }
        IServicioRepository Servicios { get; }
        ITipoPagoRepository TipoPagos { get; }
        ITipoTripulacionRepository TipoTripulaciones { get; }
        ITipoViajeRepository TipoViajes { get; }
        ITransporteRepository Transporte { get; }
        ITripulacionRepository Tripulacion { get; }
        IVentaRepository Ventas { get; }


        int SaveChange();
    }
}
