using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Angular.Core.IRepository;
using Angular.Core.IRepository.Base;
using Angular.Core.Modals.Identity;
using LinqKit;

namespace Angular.Data.Repository
{
    public class UserAccountRepository : IUserAccountRepository
    {
        private IRepository<UserAccount> _repository;

        public UserAccountRepository(IRepository<UserAccount> repository )
        {
            _repository = repository;
        }


        public  UserAccount Create()
        {
            return _repository.Create();
        }

        public void Add(UserAccount item)
        {
            _repository.Insert(item);

        
        }

        public void Remove(UserAccount item)
        {
            _repository.Insert(item);
        
        }

        public void Update(UserAccount item)
        {

        _repository.Update(item);
        }

        public UserAccount GetByID(Guid id)
        {
           return _repository.Queryable().FirstOrDefault(u => u.ID == id);
        }

        public UserAccount GetByUsername(string username)
        {
            return _repository.Queryable().FirstOrDefault(u => u.Username == username);

        }

        public UserAccount GetByUsername(string tenant, string username)
        {
            return _repository.Queryable().FirstOrDefault(u => u.Tenant.Equals(tenant) && u.Username.Equals(username));
        }

        public UserAccount GetByEmail(string tenant, string email)
        {
            return _repository.Queryable().FirstOrDefault(u => u.Tenant.Equals(tenant) && u.Email.Equals(email));
        }

        public UserAccount GetByMobilePhone(string tenant, string phone)
        {
            return _repository.Queryable().FirstOrDefault(u => u.Tenant.Equals(tenant) && u.MobilePhoneNumber.Equals(phone));
        }

        public UserAccount GetByVerificationKey(string key)
        {
            return _repository.Queryable().FirstOrDefault(u => u.VerificationKey.Equals(key));
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



            var users = _repository.Queryable();
            var q =
                from a in users
                from la in a.LinkedAccountCollection
                where la.ProviderName == provider && la.ProviderAccountID == id && a.Tenant == tenant
                select a;
            return q.SingleOrDefault();
        }

        public UserAccount GetByCertificate(string tenant, string thumbprint)
        {
            


            var certs = _repository.Queryable();
            var q =
                from a in certs
                from c in a.UserCertificateCollection
                where c.Thumbprint == thumbprint && a.Tenant == tenant
                select a;
            return q.SingleOrDefault();
        }
    }
}
