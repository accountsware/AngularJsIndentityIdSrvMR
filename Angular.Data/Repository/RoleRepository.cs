using System;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Angular.Data.IRepository;
using Angular.Data.Modals;
using Angular.Data.Repository.@base;

namespace Angular.Data.Repository
{
    public class RoleRepository: GenericRepository<Role>,IRoleRepository
    {
                public RoleRepository(DataContext context)
            :base(context)
        {
            if (context == null)
                throw new ArgumentNullException("DbContext cannot be null.");

            this._context = context;
        }

        public async Task<Role> FindByNameAsync(string roleName)
        {


            Role role = await this._context.Roles.FirstOrDefaultAsync(u => u.Name.ToLower() == roleName.ToLower());
            return role;
        }

        public IQueryable<Role> Roles { get { return _context.Roles; } }

        public virtual async Task<Role> FindByIdAsync(Guid id)
        {
            return await Task.FromResult(this._context.Roles.Find(id));
        }

        public virtual Task DeleteAsync(Role entity)
        {
            return Task.FromResult(this._context.Roles.Remove(entity));
        }

        public virtual async Task UpdateAsync(Role entity)
        {
            this._context.Roles.Attach(entity);

            this._context.Entry(entity).State = EntityState.Modified;

            await Task.FromResult(entity);


        }

        public async Task CreateAsync(Role user)
        {
            await Task.FromResult(this._context.Roles.Add(user));

        }
    }



    }

