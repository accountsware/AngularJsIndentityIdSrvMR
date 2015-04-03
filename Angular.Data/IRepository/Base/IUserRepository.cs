using System;
using System.Collections.Generic;
using System.Linq;
using Accountsware.MIS.Model.Base;
using Accountsware.MIS.Repository.Base;
using Accountsware.MIS.Model;
using System.Threading.Tasks;
using Accountsware.MIS.Model.EnumHelper;

namespace Accountsware.MIS.Repository
{
    //public interface IUserRepository : IGenericRepository<User>
    //public interface IUserRepository : IGenericRepository<ApplicationUser>
    public interface IUserRepository<T> : IGenericRepository<T>
        where T : IEntity
    {
        Task<UserActivation> GetUserActivationByToken(Guid activatioTokenId);
        Task<UserActivation> GetUserActivationById(Guid activatioTokenId);
        
        Task<List<BillingPlan>> getAllBillingPlans();

        Task removeBillingAccount(Guid billingAccountId, Guid userId);
        //Task<BillingPlan> getBillingPlan(BillingPlanType billingPlanType);Subscription
        //Task<BillingPlan> getBillingPlan(BillingPlanType billingPlanType);
        Task removePaidSubscription(Guid SubscriptionId, Guid userId);
    }
}
