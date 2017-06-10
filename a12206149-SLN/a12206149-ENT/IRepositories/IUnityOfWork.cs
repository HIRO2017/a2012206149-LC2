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
        IServicioRepository Servicios { get; }
        ITransporteRepository Transportes { get; }
        ITripulacionRepository Tripulaciones { get; }


        int SaveChanges();

        void StateModified(object entity);
    }
}
