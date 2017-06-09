using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace a12206149_ENT.IRepositories
{
    public interface IRepository<Tentity> where Tentity : class
    {

        //creates

        void Add(Tentity entity);
        void AddRange(IEnumerable<Tentity> entities);


        //reads


        Tentity Get(int Id);
        IEnumerable<Tentity> GetAll();
        IEnumerator<Tentity> Find(Expression<Func<Tentity, bool>> predicate);



        //updates


        void Update(Tentity entity);
        void UpdateRange(IEnumerable<Tentity> entities);


        //deletes



        void Delete(Tentity entity);
        void DeleteRange(IEnumerable<Tentity> entities);
    }

    }
