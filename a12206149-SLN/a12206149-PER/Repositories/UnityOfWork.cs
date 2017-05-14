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
        private readonly a12206149DbContext _DbContext;

        public IAdministrativoRepository Administrativos { get; private set; }

        public IBusRepository Buss { get; private set; }

        public IClienteRepository Clientes { get; private set; }

        public IEmpleadoRepository Empleados { get; private set; }

        public IEncomiendaRepository Encomiendas { get; private set; }

        public ILugarViajeRepository LugarViajes { get; private set; }

        public IServicioRepository Servicios { get; private set; }

        public ITipoComprobanteRepository TipoComprobantes { get; private set; }

        public ITipoLugarRepository TipoLugars { get; private set; }

        public ITipoPagoRepository TipoPagos { get; private set; }

        public ITipoTripulacionRepository TipoTripulacions { get; private set; }

        public ITipoViajeRepository TipoViajes { get; private set; }

        public ITransporteRepository Transportes { get; private set; }

        public ITripulacionRepository Tripulacions { get; private set; }

        public IVentaRepository Ventas { get; private set; }

        //SE DEFINE EL CONSTRUCTOR POR DEFECTO COMO PRIVADO PARA QUE SE FUERCE  A UTILIZAR LA PROPIEDAD INSTANCE
        private UnityOfWork()
        {
            //SE CERA UN UNICO CONTEXTO DE B-D PARA APUNTAR TODOS LOS REPOSITORIOS A LA MISMA B.D
            _DbContext = new a12206149DbContext();

            Administrativos = new AdministrativoRepository(_DbContext);
            Buss = new BusRepository(_DbContext);
            Clientes = new ClienteRepository(_DbContext);
            Empleados = new EmpleadoRepository(_DbContext);
            Encomiendas = new EncomiendaRepository(_DbContext);
            LugarViajes = new LugarViajeRepository(_DbContext);
            Servicios = new ServicioRepository(_DbContext);
            TipoComprobantes = new TipoComprobanteRepository(_DbContext);
            TipoLugars = new TipoLugarRepository(_DbContext);
            TipoPagos = new TipoPagoRepository(_DbContext);
            TipoTripulacions = new TipoTripulacionRepository(_DbContext);
            TipoViajes = new TipoViajeRepository(_DbContext);
            Transportes = new TransporteRepository(_DbContext);
            Tripulacions = new TripulacionRepository(_DbContext);
            Ventas = new VentaRepository(_DbContext);

        }
            


      
        void IDisposable.Dispose()
        {
            throw new NotImplementedException();
        }

        int IUnityOfWork.SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}
