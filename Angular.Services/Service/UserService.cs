using System.Threading.Tasks;
using Angular.Common;
using Angular.Data.IRepository;
using Angular.Data.IRepository.Base;
using Angular.Data.IServices;
using Angular.Data.Modals;
using Angular.Services.Base;
using Microsoft.AspNet.Identity;

namespace Angular.Services.Service
{
    public class UserService : BaseService,IUserService
    {
        private IUserManager _userManager { get; set; }
        private IUnitOfWork _unitOfWork { get; set; }

        public UserService(IUserManager userManager, IUnitOfWork unitOfWork) 
            : base(unitOfWork)
        {
            _userManager = userManager;
            _unitOfWork = unitOfWork;

        }




        public async Task<IdentityResult> RegisterUser(CreateUserBindingModel usr)
        {
            var user = new User();

            user.Email = usr.Email;
            user.UserName = usr.Email;


            
            var result = await _userManager.CreateAsync(user, usr.Password);

            await _unitOfWork.SaveChangesAsync();
            await _userManager.SetEmailAsync(user.Id, "what@me.com");
          await  _unitOfWork.SaveChangesAsync();

            return result;
        }


    }
}
