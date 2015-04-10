using System.Threading;
using System.Threading.Tasks;

namespace AngularJs.Core.IDataService
{
    public interface IDataContextAsync : IDataContext
    {
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
        Task<int> SaveChangesAsync();
    }
}