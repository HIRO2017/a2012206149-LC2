using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace a12206149_ENT.IRepositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        //METODOS ESTANDAR QUE DEBEN TENER TODAS LAS TABLAS :


        //C REATES
        //se agrega registro al repositorio (sql server ) en la tabla   TEntity
        void Add(TEntity entity);
        //se agrega un grupo de registro al repositorio (sql server ) en la tabla   TEntity
        void AddRange(IEnumerable<TEntity> entity);

        //R EADS  
        //se obtiene el registro con Primary Key = Id de la tabla TEntity
        TEntity Get(int Id);
        //se obtiene todos los registros de la tabla TEntity 
        IEnumerable<TEntity> GetAll();
        //se obtiene todos los registros de la tabla TEntity que cumplan  con la condicion predicate
        //predicate es una expresion lambda que tiene  parámetros de entrada a Tentity y el devuelve una expresion boobleana. si esa
        //expresion es true para un registro. entonces dicho registro se agrega a la lista de registro a devolver en la app
        IEnumerator<TEntity> Find(Expression<Func<TEntity, bool>> predicate);
        //U PDATES
        //actualiza un registro al repositorio (sql server) a la tabla TEntity
        void Update(TEntity entity);
        //actualiza un grupo de registros al repositorio (sql server) a la tabla TEntity
        void UpdateRange(IEnumerable<TEntity> entities);
        //D ELETES
        //Elimina un registro al repositorio (sql server) a la tabla TEntity
        void Delete(TEntity entiy);
        //Elimina un grupo de registros al repositorio (sql server)a la tabla Entity
        void DeleteRange(IEnumerable<TEntity> entities);
    }
}
