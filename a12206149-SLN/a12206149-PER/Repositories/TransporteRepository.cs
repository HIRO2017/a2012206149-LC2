﻿using a12206149_ENT.Entities;
using a12206149_ENT.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a12206149_PER.Repositories
{
    public class TransporteRepository : Repository<Transporte>, ITransporteRepository
    {

        public TransporteRepository(a12206149DbContext context) : base(context)
        {
        }
    }
}
