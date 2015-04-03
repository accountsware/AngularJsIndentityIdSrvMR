using System;
using System.Threading.Tasks;
using Angular.Data.IRepository.Base;

namespace Angular.Data.Repository.@base
{
    public class UnitOfWork : IUnitOfWork
    {
        protected DataContext _context ;

        public UnitOfWork(DataContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException("Context argument cannot be null in UnitOfWork.");
            }

            this._context = context;
        }

        public void SaveChanges()
        {
            this._context.SaveChanges();
        }

        public async Task SaveChangesAsync()
        {
            await this._context.SaveChangesAsync();
        }

        public void Dispose()
        {
            if (this._context != null)
            {
                this._context.Dispose();
            }
        }
    }
}
