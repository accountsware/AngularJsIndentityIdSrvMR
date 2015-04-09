using System.Threading;
using System.Threading.Tasks;


namespace Angular.Data.IRepository.Base
{
    public interface IDataContextAsync : IDataContext
    {
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
        Task<int> SaveChangesAsync();
    }
}