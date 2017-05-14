using a12206149_ENT.ENT.Entities;
using a12206149_ENT.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a12206149_PER.Repositories
{
    public class EncomiendaRepository : Repository<Encomienda>, IEncomiendaRepository
    {
        private readonly a12206149DbContext _DbContext;

        public EncomiendaRepository(a12206149DbContext dbContext)
        {
            _DbContext = dbContext;
        }

        private EncomiendaRepository()
        {

        }
    }
}
