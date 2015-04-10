using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Angular.Core.Modals;

namespace Angular.Data.Mappings
{
    class UserRoleMap : EntityTypeConfiguration<UserRole>
    {
        public UserRoleMap()
        {
            this.ToTable("UserRole");

            this.HasKey(r => new { r.RoleId, r.UserId });

        }
    }
}
