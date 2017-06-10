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
        //private static UnityOfWork _Instance;
        //public static readonly object _Lock = new object();

        public IAdministrativoRepository Administrativos { get; private set; }

        public IBusRepository Buses { get; private set; }

        public IClienteRepository Clientes { get; private set; }

        public IEmpleadoRepository Empleados { get; private set; }

        public IEncomiendaRepository Encomiendas { get; private set; }

        public IServicioRepository Servicios { get; private set; }

        public ITransporteRepository Transportes { get; private set; }

        public ITripulacionRepository Tripulaciones { get; private set; }

        public IVentaRepository Ventas { get; private set; }


        public  UnityOfWork()
        {
            _Context = new a12206149DbContext();

            Administrativos = new AdministradorRepository(_Context);
            Buses = new BusRepository(_Context);
            Clientes = new ClienteRepository(_Context);
            Empleados = new EmpleadoRepository(_Context);
            Encomiendas = new EncomiendaRepository(_Context);
            Servicios = new ServicioRepository(_Context);
            Transportes = new TransporteRepository(_Context);
            Tripulaciones = new TripulacionRepository(_Context);
            Ventas = new VentaRepository(_Context);
        }



        //public static UnityOfWork Instance
        //{
          //  get
          //  {

        //
            //    lock (_Lock)
            //    {

             //       if (_Instance == null)
             //           _Instance = new UnityOfWork();


              //  }


              //  return _Instance;
//}



       // }



        
        public void Dispose()
        {
            _Context.Dispose();
        }

        public int SaveChanges()
        {
          return    _Context.SaveChanges();
        }

        public void StateModified(object Entity)
        {
            _Context.Entry(Entity).State = System.Data.Entity.EntityState.Modified;
        }
    }
}
