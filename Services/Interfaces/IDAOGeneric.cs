using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Services.Interfaces
{
    public interface IDAOGeneric<TEntity> where TEntity :class
    {

        int Add(TEntity entity);

        TEntity Get(int Id);
        int Update(TEntity entity);

        IEnumerable<TEntity> GetAll();

        IEnumerable<TEntity> SingleOrDefault(Expression<Func<TEntity, bool>> predicate);

        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);

        int Delete(TEntity entity);








    }
}
