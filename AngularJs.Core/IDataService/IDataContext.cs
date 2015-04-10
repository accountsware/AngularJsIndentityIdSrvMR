using System;
using AngularJs.Core.Modals.Base;

namespace AngularJs.Core.IDataService
{
    public interface IDataContext : IDisposable
    {
        int SaveChanges();
        void SyncObjectState<TEntity>(TEntity entity) where TEntity : class, IObjectState;
        void SyncObjectsStatePostCommit();
    }
}