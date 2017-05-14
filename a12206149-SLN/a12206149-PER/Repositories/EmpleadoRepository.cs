﻿using a12206149_ENT.ENT.Entities;
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
        private readonly a12206149DbContext _DbContext;

        public EmpleadoRepository(a12206149DbContext dbContext)
        {
            _DbContext = dbContext;
        }

        private EmpleadoRepository()
        {

        }
    }
}
