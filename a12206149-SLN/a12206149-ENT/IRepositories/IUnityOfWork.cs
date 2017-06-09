using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a12206149_ENT.IRepositories
{
    public interface IUnityOfWork : IDisposable
    {
        //CADA UNA DE LAS PROPIEDADES DEBEN SER DE SOLO "LECTURA"

        IAdministrativoRepository Administrativos { get; }
        IBusRepository Buss { get; }
        IClienteRepository Clientes { get; }
        IEncomiendaRepository Encomiendas { get; }
        ILugarViajeRepository LugarViajes { get; }
        ITransporteRepository Transportes { get; }
        ITripulacionRepository Tripulacions { get; }
        IVentaRepository Ventas { get; }



        //METODO QUE GUARDA CAMBIOS EN LA B.D

        int SaveChanges();
    }
}
