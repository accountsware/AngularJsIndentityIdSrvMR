using System.Threading;
using System.Threading.Tasks;
using AngularJs.Core.Modals.Base;

namespace Angular.Data.IRepository.Base
{
    public interface IUnitOfWorkAsync : IUnitOfWork
    {
        Task<int> SaveChangesAsync();
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
        IRepositoryAsync<TEntity> RepositoryAsync<TEntity>() where TEntity : class, IObjectState;
    }
}