﻿using a12206149_ENT.ENT.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a12206149_ENT.IRepositories
{
    public interface IClienteRepository : IRepository<Cliente>
    {
        Cliente Get(int? id);
    }
}
