using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Angular.Data.IRepository.Base;
using Angular.Data.Modals;
using Microsoft.AspNet.Identity;

namespace Angular.Data.IRepository
{
    public interface IRoleRepository: IGenericRepository<Role>, IRoleStore<Role,Guid>
    {
        /// <summary>
        ///     Create a new role
        /// </summary>
        /// <param name="role"></param>
        /// <returns></returns>
        Task CreateAsync(Role role);

        /// <summary>
        ///     Update a role
        /// </summary>
        /// <param name="role"></param>
        /// <returns></returns>
        Task UpdateAsync(Role role);

        /// <summary>
        ///     Delete a role
        /// </summary>
        /// <param name="role"></param>
        /// <returns></returns>
        Task DeleteAsync(Role role);

        /// <summary>
        ///     Find a role by id
        /// </summary>
        /// <param name="roleId"></param>
        /// <returns></returns>
        Task<Role> FindByIdAsync(Guid roleId);

        /// <summary>
        ///     Find a role by name
        /// </summary>
        /// <param name="roleName"></param>
        /// <returns></returns>
        Task<Role> FindByNameAsync(string roleName);

        IQueryable<Role> Roles { get;  }
    }
}
