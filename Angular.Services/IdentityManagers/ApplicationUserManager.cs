using System;
using Angular.Data.IRepository;
using Angular.Data.IServices;
using Angular.Data.Modals;
using Microsoft.AspNet.Identity;


namespace Angular.Services.IdentityManagers
{
    public class ApplicationUserManager : UserManager<User, Guid>, IUserManager
    {

 //       public ApplicationUserManager() { }

        

        public ApplicationUserManager(IUserRepository<User> userRepository)
            : base(userRepository)
        {
            
            //Store = userRepository;

             
           
            this.UserValidator = new UserValidator<User, Guid>(this)
            {
                AllowOnlyAlphanumericUserNames = false,
                RequireUniqueEmail = true
            };
            // Configure validation logic for passwords
            this.PasswordValidator = new PasswordValidator
            {
                RequiredLength = 6,
                RequireNonLetterOrDigit = true,
                RequireDigit = true,
                RequireLowercase = true,
                RequireUppercase = true,
            };
            
        }
    }
}
