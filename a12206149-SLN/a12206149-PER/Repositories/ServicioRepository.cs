﻿using a12206149_ENT.Entities;
using a12206149_ENT.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a12206149_PER.Repositories
{
    public class ServicioRepository : Repository<Servicio>, IServicioRepository
    {

        public ServicioRepository(a12206149DbContext context) : base(context)
        {
        }
    }
}
