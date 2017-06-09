using a12206149_ENT.Entities;
using a12206149_ENT.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a12206149_PER.Repositories
{
    public class AdministrartivoRepository : Repository<Administrativo>, IAdministrativoRepository
    {
        private a12206149DbContext _Context;

        public AdministrartivoRepository(a12206149DbContext context)
        {
            _Context = context;
        }

        IEnumerable<Administrativo> IAdministrativoRepository.GetAdministrativoByClassification(Empleado empleado)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Administrativo> IAdministrativoRepository.GetAdministrativoWhthTransporte(int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }
    }
}
