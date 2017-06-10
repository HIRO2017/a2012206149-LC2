using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using a12206149_ENT.Entities;
using a12206149_ENT.IRepositories;

namespace a12206149_PER.Repositories
{
    public  class AdministradorRepository : Repository<Administrativo>, IAdministrativoRepository
    {

        public AdministradorRepository(a12206149DbContext context) : base(context)
        {
            
        }

        
    }
}