using a12206149_ENT;
using a12206149_ENT.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a12206149_PER.Repositories
{
    public class EmpleadoRepository : Repository<Empleado>, IEmpleadoRepository
    {
        IEnumerable<Empleado> IEmpleadoRepository.GetEmpleadoWithTransporte(int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }
    }
}
