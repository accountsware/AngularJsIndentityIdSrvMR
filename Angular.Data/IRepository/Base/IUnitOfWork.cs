using System;
using System.Threading.Tasks;

namespace Angular.Data.IRepository.Base
{
    public interface IUnitOfWork : IDisposable
    {

        void SaveChanges();
        Task SaveChangesAsync();
    }
}
