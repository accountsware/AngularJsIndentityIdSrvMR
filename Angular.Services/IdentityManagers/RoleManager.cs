using System;
using Angular.Data.IServices;
using Angular.Data.Modals;
using Microsoft.AspNet.Identity;



namespace Angular.Services
{
    public class ApplicationRoleManager : RoleManager<Role, Guid>, IRoleManager
    {
        public ApplicationRoleManager(IRoleStore<Role, Guid> store)
            : base(store)
        {

        }
    }
}
