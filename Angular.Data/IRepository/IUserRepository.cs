using System;

using System.Threading.Tasks;
using Angular.Data.IRepository.Base;
using Angular.Data.Modals;
using Microsoft.AspNet.Identity;

namespace Angular.Data.IRepository
{
    public interface IUserRepository<T>:IUserStore<User,Guid> , IGenericRepository<T> where T : class 
    {
        /// <summary>
        ///     Insert a new user
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        Task CreateAsync(User user);

        /// <summary>
        ///     Update a user
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        Task UpdateAsync(User user);

        /// <summary>
        ///     Delete a user
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        Task DeleteAsync(User user);

        /// <summary>
        ///     Finds a user
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        Task<User> FindByIdAsync(Guid userId);

        /// <summary>
        ///     Find a user by name
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        Task<User> FindByNameAsync(string userName);
    }
}
