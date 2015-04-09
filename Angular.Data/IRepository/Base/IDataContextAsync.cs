using System.Threading;
using System.Threading.Tasks;
using AngularJs.Core.Modals.Base;

namespace Angular.Data.IRepository.Base
{
    public interface IDataContextAsync : IDataContext
    {
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
        Task<int> SaveChangesAsync();
    }
}