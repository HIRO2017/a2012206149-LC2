using a12206149_ENT.ENT.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a12206149_ENT.IRepositories
{
    public interface IAdministrativoRepository : IRepository<Administrativo>
    {
        //obtener la relacion de administrativo
        //el resultado se devolvera de acuerdo a parámetros 
        IEnumerable<Administrativo> GetAdministrativosWithEmpleado(int pageIndex, int pageSize);

        //obtener la relacion de administrativos que sean empleados
        IEnumerable<Administrativo> GetAdministativoByEmpeledo(Empleado Empleado);

    }
}
