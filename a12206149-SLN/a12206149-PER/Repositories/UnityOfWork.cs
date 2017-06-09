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
        private static UnityOfWork _Instance;
        private static readonly object _Lock = new object();

        public IAdministrativoRepository Administrativos { get; private set; }

        public IBusRepository Buses { get; private set; }

        public IClienteRepository Clientes { get; private set; }

        public IEmpleadoRepository Empleados { get; private set; }

        public IEncomiendaRepository Encomiendas { get; private set; }

        public ILugarViajeRepository LugarViajes { get; private set; }

        public IServicioRepository Servicios { get; private set; }

        public ITipoPagoRepository TipoPagos { get; private set; }

        public ITipoTripulacionRepository TipoTripulaciones { get; private set; }

        public ITipoViajeRepository TipoViajes { get; private set; }

        public ITransporteRepository Transporte { get; private set; }

        public ITripulacionRepository Tripulacion { get; private set; }

        public IVentaRepository Ventas { get; private set; }




        private UnityOfWork()
        {
            _Context = new a12206149DbContext();

            Administrativos = new AdministrartivoRepository(_Context);
            Buses = new BusRepository(_Context);
            Clientes = new ClienteRepository(_Context);
            Empleados = new EmpleadoRepository(_Context);
            Encomiendas = new EncomiendaRepository(_Context);
            LugarViajes = new LugarViajeRepository(_Context);
            TipoPagos = new TipoPagoRepository(_Context);
            TipoViajes = new TipoViajeRepository(_Context);
            Transporte = new TransporteRepository(_Context);
            Tripulacion = new TripulacionRepository(_Context);
            Ventas = new VentaRepository(_Context);
            TipoTripulaciones = new TipoTripulacionRepository(_Context);

        }


        public static UnityOfWork Instance
        {
            get
            {
                lock (_Lock)
                {
                    if (_Instance == null)
                        _Instance = new UnityOfWork();
                }

                return _Instance;
            }
        }


        public void Dispose()
        {
            _Context.Dispose();
        }

        public int SaveChange()
        {
           return  _Context.SaveChanges();
        }
    }
}
    