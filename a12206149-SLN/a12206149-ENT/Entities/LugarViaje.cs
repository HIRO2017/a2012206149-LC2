﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a12206149_ENT.ENT.Entities
{
    public class LugarViaje
    {
        public TipoLugar TipoLugar { get; set; }
        public string Descripcion { get; set; }


        public LugarViaje()
        {
            TipoLugar = new TipoLugar();
        }
    }
}
