using System.Threading;
using System.Threading.Tasks;
using Angular.Core.Modals.Base;

namespace Angular.Core.IRepository.Base
{
    public interface IUnitOfWorkAsync : IUnitOfWork
    {
        Task<int> SaveChangesAsync();
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
        IRepositoryAsync<TEntity> RepositoryAsync<TEntity>() where TEntity : class, IObjectState;
    }
}