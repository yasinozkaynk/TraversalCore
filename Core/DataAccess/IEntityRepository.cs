using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess
{
    public interface IEntityRepository<A> where A : class, IEntity, new()
    {
        List<A> GetAll(Expression<Func<A, bool>> filter = null);
        A Get(Expression<Func<A, bool>> filter);
        void Add(A entity);
        void Update(A entity);
        void Delete(A entity);

    }
}
