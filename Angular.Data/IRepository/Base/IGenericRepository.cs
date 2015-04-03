using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Angular.Data.IRepository.Base
{
    public interface IGenericRepository<T> 
        where T : class 
    {
        Task<int> CountAsync();
        Task<int> CountAsync(Expression<Func<T, bool>> predicate);
        Task<T> FindAsync(Guid id);
        Task<List<T>> GetAllAsync();
        Task<List<T>> FindAsync(Expression<Func<T, bool>> predicate);
        Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> predicate);
        T Add(T entity);
        T Delete(T entity);
        T Update(T entity);
    }
}
