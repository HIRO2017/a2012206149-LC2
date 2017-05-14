﻿using a12206149_ENT.ENT.Entities;
using a12206149_ENT.IRepositories;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a12206149_PER.Repositories
{
    public class AdministrativoRepository : Repository<Administrativo>, IAdministrativoRepository
    {
        private readonly a12206149DbContext _DbContext;

        private AdministrativoRepository()
        {

        }

        public AdministrativoRepository(a12206149DbContext context)
        {
            _DbContext = context;
        }


        IEnumerable<Administrativo> IAdministrativoRepository.GetAdministativoByEmpeledo(Empleado Empleado)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Administrativo> IAdministrativoRepository.GetAdministrativosWithEmpleado(int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }
    }
}