using a12206149_ENT.ENT.Entities;
using a12206149_ENT.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a12206149_PER.Repositories
{
    public class ClienteRepository : Repository<Cliente>, IClienteRepository
    {
        private readonly a12206149DbContext _DbContext;

        public ClienteRepository(a12206149DbContext dbContext)
        {
            _DbContext = dbContext;
        }

        private ClienteRepository()
        {

        }

        public Cliente Get(int? id)
        {
            throw new NotImplementedException();
        }
    }
}
