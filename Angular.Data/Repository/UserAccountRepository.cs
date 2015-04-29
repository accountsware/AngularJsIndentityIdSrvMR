using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Angular.Core.IRepository;
using Angular.Core.IRepository.Base;
using Angular.Core.Modals.Identity;
using Angular.Data.Context;
using Angular.Data.DbContextInterfaces;
using LinqKit;

namespace Angular.Data.Repository
{
    public class UserAccountRepository : IUserAccountRepository
    {

        private readonly IAmbientDbContextLocator _ambientDbContextLocator;

        private AngularContext DbContext
        {
            get
            {
                var dbContext = _ambientDbContextLocator.Get<AngularContext>();

                if (dbContext == null)
                    throw new InvalidOperationException("No ambient DbContext of type UserManagementDbContext found. This means that this repository method has been called outside of the scope of a DbContextScope. A repository must only be accessed within the scope of a DbContextScope, which takes care of creating the DbContext instances that the repositories need and making them available as ambient contexts. This is what ensures that, for any given DbContext-derived type, the same instance is used throughout the duration of a business transaction. To fix this issue, use IDbContextScopeFactory in your top-level business logic service method to create a DbContextScope that wraps the entire business transaction that your service method implements. Then access this repository within that scope. Refer to the comments in the IDbContextScope.cs file for more details.");

                return dbContext;
            }
        }
        
        
        
        
        private IRepository<UserAccount> _repository;

        public UserAccountRepository(IAmbientDbContextLocator ambientDbContextLocator)
		{
			if (ambientDbContextLocator == null) throw new ArgumentNullException("ambientDbContextLocator");
			_ambientDbContextLocator = ambientDbContextLocator;
		}



        public  UserAccount Create()
        {
            return DbContext.Users.Create();
        }

        public void Add(UserAccount item)
        {
            DbContext.Users.Add(item);


        }

        public void Remove(UserAccount item)
        {
            DbContext.Users.Remove(item);
        
        }

        public void Update(UserAccount item)
        {

            DbContext.Users.Attach(item);
        }

        public UserAccount GetByID(Guid id)
        {
            return DbContext.Users.FirstOrDefault(u => u.ID == id);
        }

        public UserAccount GetByUsername(string username)
        {
            return DbContext.Users.FirstOrDefault(u => u.Username == username);

        }

        public UserAccount GetByUsername(string tenant, string username)
        {
            return DbContext.Users.FirstOrDefault(u => u.Tenant.Equals(tenant) && u.Username.Equals(username));
        }

        public UserAccount GetByEmail(string tenant, string email)
        {
            return DbContext.Users.FirstOrDefault(u => u.Tenant.Equals(tenant) && u.Email.Equals(email));
        }

        public UserAccount GetByMobilePhone(string tenant, string phone)
        {
            return DbContext.Users.FirstOrDefault(u => u.Tenant.Equals(tenant) && u.MobilePhoneNumber.Equals(phone));
        }

        public UserAccount GetByVerificationKey(string key)
        {
            return DbContext.Users.FirstOrDefault(u => u.VerificationKey.Equals(key));
        }

        public UserAccount GetByLinkedAccount(string tenant, string provider, string id)
        {

            //return
            //    _repository
            //        .Queryable()
            //        .Where(u => u.Tenant.Equals(tenant))
            //        .Include(
            //            u =>
            //                u.LinkedAccountCollection.Select(
            //                    p => p.ProviderAccountID.Equals(id) && p.ProviderName.Equals(provider)))
            //        .SingleOrDefault();



            var users = DbContext.Users;
            var q =
                from a in users
                from la in a.LinkedAccountCollection
                where la.ProviderName == provider && la.ProviderAccountID == id && a.Tenant == tenant
                select a;
            return q.SingleOrDefault();
        }

        public UserAccount GetByCertificate(string tenant, string thumbprint)
        {



            var certs = DbContext.Users;
            var q =
                from a in certs
                from c in a.UserCertificateCollection
                where c.Thumbprint == thumbprint && a.Tenant == tenant
                select a;
            return q.SingleOrDefault();
        }
    }
}
