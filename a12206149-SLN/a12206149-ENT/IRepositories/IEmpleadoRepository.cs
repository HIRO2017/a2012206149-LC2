using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a12206149_ENT.IRepositories
{
    public interface IEmpleadoRepository : IRepository<Empleado>
    {
        IEnumerable<Empleado> GetEmpleadoWithTransporte(int pageIndex, int pageSize);



    }
}
