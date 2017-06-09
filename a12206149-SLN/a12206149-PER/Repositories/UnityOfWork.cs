using a12206149_ENT.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a12206149_PER.Repositories
{
    public class UnityOfWork : IUnityOfWork
    {
        private readonly a12206149DbContext _Context;

        public IAdministrativoRepository Administrativos { get; private set; }

        public IBusRepository Buses { get; private set; }

        public IClienteRepository Clientes { get; private set; }

        public IEmpleadoRepository Empleados { get; private set; }

        public IEncomiendaRepository Encomiendas { get; private set; }

        public ILugarViajeRepository LugarViajes { get; private set; }

        public IServicioRepository Iervicios { get; private set; }

        public ITipoPagoRepository TipoPagos { get; private set; }

        public ITipoTripulacionRepository ipoTripulaciones { get; private set; }

        public ITipoViajeRepository TipoViajes { get; private set; }

        public ITransporteRepository Transporte { get; private set; }

        public ITripulacionRepository Tripulacion { get; private set; }

        public  IVentaRepository Ventas { get; private set; }


        private UnityOfWork()
        {
            _Context = new a12206149DbContext();
        }

        void IDisposable.Dispose()
        {
            throw new NotImplementedException();
        }

        int IUnityOfWork.SaveChange()
        {
            throw new NotImplementedException();
        }
    }
}
