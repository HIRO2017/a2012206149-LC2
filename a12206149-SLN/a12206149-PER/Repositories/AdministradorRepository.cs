using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using a12206149_ENT.Entities;
using a12206149_ENT.IRepositories;

namespace a12206149_PER.Repositories
{
    internal class AdministradorRepository : IAdministrativoRepository
    {
        private a12206149DbContext _Context;

        public AdministradorRepository(a12206149DbContext context)
        {
            _Context = context;
        }

        void IRepository<Administrativo>.Add(Administrativo entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Administrativo>.AddRange(IEnumerable<Administrativo> entities)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Administrativo> IRepository<Administrativo>.Find(Expression<Func<Administrativo, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        Administrativo IRepository<Administrativo>.Get(int? id)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Administrativo> IAdministrativoRepository.GetAdministrativoByServicio(Servicio servicio)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Administrativo> IAdministrativoRepository.GetAdministrativoWithTransporte(int pageIndex, int pageSize)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Administrativo> IRepository<Administrativo>.GetAll()
        {
            throw new NotImplementedException();
        }

        void IRepository<Administrativo>.Remove(Administrativo entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Administrativo>.RemoveRange(IEnumerable<Administrativo> entities)
        {
            throw new NotImplementedException();
        }

        void IRepository<Administrativo>.Update(Administrativo entity)
        {
            throw new NotImplementedException();
        }

        void IRepository<Administrativo>.UpdateRange(IEnumerable<Administrativo> entities)
        {
            throw new NotImplementedException();
        }
    }
}