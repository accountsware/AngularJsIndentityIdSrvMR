using System;
using Angular.Data;
using Angular.Data.IRepository;
using Angular.Data.IRepository.Base;
using Angular.Data.IServices;
using Angular.Data.Modals;
using Angular.Data.Repository;
using Angular.Data.Repository.@base;
using Angular.Services;
using Angular.Services.IdentityManagers;
using Angular.Services.Service;
using Microsoft.AspNet.Identity;
using Microsoft.Practices.Unity;

namespace Angular.Bootstrapper
{
    /// <summary>
    /// Specifies the Unity configuration for the main container.
    /// </summary>
    public class UnityConfig
    {
        #region Unity Container
        private static Lazy<IUnityContainer> container = new Lazy<IUnityContainer>(() =>
        {
            var container = new UnityContainer();
            RegisterTypes(container);
            return container;
        });

        /// <summary>
        /// Gets the configured Unity container.
        /// </summary>
        public static IUnityContainer GetConfiguredContainer()
        {
            return container.Value;
        }
        #endregion

        /// <summary>Registers the type mappings with the Unity container.</summary>
        /// <param name="container">The unity container to configure.</param>
        /// <remarks>There is no need to register concrete types such as controllers or API controllers (unless you want to 
        /// change the defaults), as Unity allows resolving a concrete type even if it was not previously registered.</remarks>
        public static void RegisterTypes(IUnityContainer container)
        {


            // TODO: Register your types here
            container.RegisterType<DataContext>(new PerResolveLifetimeManager());
            container.RegisterType<IUnitOfWork, UnitOfWork>(new PerResolveLifetimeManager());
            container.RegisterType<IUserStore<User, Guid>, UserRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<IRoleStore<Role, Guid>, RoleRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<IUserRepository<User>, UserRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<IPersonRepository, PersonRepository>(new HierarchicalLifetimeManager());
            container.RegisterType<IPersonService, PersonService>(new HierarchicalLifetimeManager());
            container.RegisterType<IUserService, UserService>(new HierarchicalLifetimeManager());
            container.RegisterType<IUserManager, ApplicationUserManager>(new HierarchicalLifetimeManager());
            container.RegisterType<IRoleManager, ApplicationRoleManager>(new HierarchicalLifetimeManager());
            
        }
    }
}
