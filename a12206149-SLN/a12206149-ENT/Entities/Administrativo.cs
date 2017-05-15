using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a12206149_ENT.ENT.Entities
{
    public class Administrativo : Empleado
    {
        public int AdministrativoId { get; set; }
        public string Classificaion { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
    }
}
