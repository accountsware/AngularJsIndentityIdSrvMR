using System.Threading.Tasks;
using Angular.Common;
using Angular.Data.IServices.Base;
using Angular.Data.Modals;
using Microsoft.AspNet.Identity;

namespace Angular.Data.IServices
{
    public interface IUserService: IService

    {
      //  IUserManager UserManager { get; set; }
        Task<IdentityResult> RegisterUser(CreateUserBindingModel usr);
        
      
    }
}