using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Ua.UdemyTodoAppNTier.Entities.Concrete;

namespace Ua.UdemyTodoNTier.DataAccess.Interfaces
{
    public interface IRepository<T>where T :BaseEntity
    {
        Task<List<T>> GetAll();
        Task<T> GetByFilter(Expression<Func<T, bool>> filter,bool asNoTracking=false);   
        Task<T> Find(object id);
        Task Create(T entity);
        void Update(T entity, T Unchanged);
        void Remove(T entity);
        IQueryable<T> GetQuery();

    }
}
