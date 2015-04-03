using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Angular.Data.IRepository;
using Angular.Data.Modals;
using Angular.Data.Repository.@base;
using Microsoft.AspNet.Identity;

namespace Angular.Data.Repository
{
    public class UserRepository : GenericRepository<User>, IUserRepository<User>, IUserStore<User, Guid>
        , IUserRoleStore<User, Guid>
        , IUserPasswordStore<User, Guid>
        , IUserSecurityStampStore<User, Guid>
        , IUserEmailStore<User, Guid>
        
    {

       
        public UserRepository(DataContext context)
            : base(context)
        {

            if (context == null)
                throw new ArgumentNullException("DbContext cannot be null.");

            this._context = context;
        }


        #region private methods

        private void CheckParamForNull(object param, string paramName)
        {
            if (param == null)
                throw new ArgumentNullException(string.Format("{0} cannot be null.", paramName));
        }

        private void CheckStringParamForNullOrEmpty(string param, string paramName)
        {
            if (param == null)
                throw new ArgumentNullException(string.Format("{0} cannot be null or empty.", paramName));
        }

        private Role GetAppRole(string roleName)
        {
            var role = this._context.Roles.FirstOrDefault(r => r.Name.ToUpper() == roleName.ToUpper());
            if (role == null)
                throw new InvalidOperationException("Role does not exist.");

            return role;
        }

        #endregion

        #region IUserStore

        public async Task<User> FindByNameAsync(string username)
        {
            this.CheckStringParamForNullOrEmpty(username, "Username");

            return await this._context.Users.Where(u => u.UserName.ToLower() == username.ToLower()).FirstOrDefaultAsync();
        }

        public async Task<User> FindByIdAsync(Guid userId)
        {
            this.CheckParamForNull(userId, "User Id");

            return await this._context.Users.Where(u => u.Id == userId).FirstOrDefaultAsync();
        }

        public async Task DeleteAsync(User user)
        {
            this.CheckParamForNull(user, "User");

            this._context.Users.Remove(user);
       //     await this._context.SaveChangesAsync();
        }

        public async Task UpdateAsync(User user)
        {
            this.CheckParamForNull(user, "User");

            this._context.Users.Attach(user);
            this._context.Entry(user).State = EntityState.Modified;

    //        await this._context.SaveChangesAsync();
        }

        public async Task CreateAsync(User user)
        {
            this.CheckParamForNull(user, "User");

            this._context.Users.Add(user);
          await this._context.SaveChangesAsync();
        }

        #endregion

        #region IUserPassowrdStore
        public async Task<bool> HasPasswordAsync(User user)
        {
            return await Task.FromResult<bool>(string.IsNullOrEmpty(user.PasswordHash));
        }

        public Task<string> GetPasswordHashAsync(User user)
        {
            this.CheckParamForNull(user, "User");

            return Task.FromResult<string>(user.PasswordHash);
        }

        public  Task SetPasswordHashAsync(User user, string passwordHash)
        {
            this.CheckParamForNull(user, "User");

            this.CheckStringParamForNullOrEmpty(passwordHash, "Password Hash");

            user.PasswordHash = passwordHash;


            return Task.FromResult(0);
        }
        #endregion

        #region IUserRoleStore

        public virtual async Task<bool> IsInRoleAsync(User user, string roleName)
        {
            this.CheckParamForNull(user, "User");

            this.CheckStringParamForNullOrEmpty(roleName, "Role Name");

            var appRole = GetAppRole(roleName);

            return await Task.FromResult<bool>(user.Roles.FirstOrDefault(r => r.Role.Id == appRole.Id) != null);
        }

        public virtual Task<IList<string>> GetRolesAsync(User user)
        {
            this.CheckParamForNull(user, "User");

            return Task.FromResult<IList<string>>(user.Roles.ToList().Select(u => u.Role.Name).ToList());
        }

        public async Task AddToRoleAsync(User user, string roleName)
        {
            this.CheckParamForNull(user, "User");
            this.CheckStringParamForNullOrEmpty(roleName, "Role Name");
            var role = GetAppRole(roleName);

            user.Roles.Add(new UserRole
            {
                Role = role,
                User = user
            });

            await this.UpdateAsync(user);
        }

        public async Task RemoveFromRoleAsync(User user, string roleName)
        {
            this.CheckParamForNull(user, "User");
            this.CheckStringParamForNullOrEmpty(roleName, "Role Name");
            var role = GetAppRole(roleName);

            var userRole = this._context.Set<UserRole>().Where(r => r.User.Id == user.Id && r.Role.Id == role.Id).FirstOrDefault();
            if (userRole == null)
            {
                throw new InvalidOperationException("User cannot be removed from this role. User does not have this role.");
            }

            this._context.Set<UserRole>().Remove(userRole);

            await this.UpdateAsync(user);
        }

        #endregion

        #region IUserSecurityStampStore

        public Task<string> GetSecurityStampAsync(User user)
        {
            this.CheckParamForNull(user, "User");

            return Task.FromResult<string>(user.SecurityStamp);
        }

        public Task SetSecurityStampAsync(User user, string stamp)
        {
            this.CheckParamForNull(user, "User");
            this.CheckStringParamForNullOrEmpty(stamp, "Security Stamp");

            user.SecurityStamp = stamp;
            return Task.FromResult<int>(0);
        }

        #endregion

        #region IUserEmailStore

        public Task<User> FindByEmailAsync(string email)
        {
            this.CheckStringParamForNullOrEmpty(email, "Email");

            return this._context.Users.Where(u => u.Email.ToLower() == email.ToLower())
                .FirstOrDefaultAsync();
        }

        public Task<string> GetEmailAsync(User user)
        {
            this.CheckParamForNull(user, "User");

            return Task.FromResult<string>(user.Email);
        }

        public Task<bool> GetEmailConfirmedAsync(User user)
        {
            this.CheckParamForNull(user, "User");

            return Task.FromResult<bool>(user.EmailConfirmed);
        }

        public Task SetEmailAsync(User user, string email)
        {
            this.CheckParamForNull(user, "User");
            this.CheckStringParamForNullOrEmpty(email, "Email");

            user.Email = email;
            return Task.FromResult<int>(0);
        }

        public Task SetEmailConfirmedAsync(User user, bool confirmed)
        {
            this.CheckParamForNull(user, "User");

            user.EmailConfirmed = confirmed;
            return Task.FromResult<int>(0);
        }

        #endregion




    }
}
