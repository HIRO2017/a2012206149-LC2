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
        private readonly EmpleadoDbContext _Context;

        private EmpleadoRepository()
        {

        }

        public EmpleadoRepository(EmpleadoDbContext context)
        {
            _Context = context;
        }



        IEnumerable<Empleado> IEmpleadoRepository.GetEmpleadoWithTransporte(int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

    }

}