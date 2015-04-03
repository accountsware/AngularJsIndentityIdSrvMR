using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Angular.Data.IRepository.Base;

namespace Angular.Data.Repository.@base
{
    public abstract class GenericRepository<T> : IGenericRepository<T>, IDisposable
      where T : class 
    {
        protected DataContext _context;
        protected readonly IDbSet<T> _dbset;

        public GenericRepository(DataContext context)
        {
            if (context == null)
            {
                throw new ApplicationException("DbContext cannot be null.");
            }

            _context = context;
            _dbset = context.Set<T>();
        }

        public virtual async Task<int> CountAsync()
        {
            return await _dbset.CountAsync();
        }

        public virtual async Task<int> CountAsync(Expression<Func<T, bool>> predicate)
        {
            return await _dbset.CountAsync(predicate);
        }

        public virtual async Task<List<T>> GetAllAsync()
        {

            return await _dbset.ToListAsync<T>();
        }

        public virtual async Task<T> FindAsync(Guid id)
        {
            return await Task.FromResult<T>(_dbset.Find(id));
        }

        public async Task<List<T>> FindAsync(Expression<Func<T, bool>> predicate)
        {
            Task<List<T>> query = this._dbset.Where(predicate).ToListAsync();
            return await query;
        }

        public async Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> predicate)
        {
            Task<T> query = this._dbset.FirstOrDefaultAsync(predicate);
            return await query;
        }

        public virtual T Add(T entity)
        {
            return this._dbset.Add(entity);
        }

        public virtual T Delete(T entity)
        {

            return this._dbset.Remove(entity);
        }

        public virtual T Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            return entity;
        }



        public void Dispose()
        {

        }
    }
}
