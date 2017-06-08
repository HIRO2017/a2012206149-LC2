using a12206149_ENT.Entities;
using a12206149_ENT.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a12206149_PER.Repositories
{
    public class TipoLugarRepository : Repository<TipoLugar>, ITipoLugarRepository
    {
        private EmpleadoDbContext _Context;

        public TipoLugarRepository(EmpleadoDbContext context)
        {
            _Context = context;
        }
    }
}
