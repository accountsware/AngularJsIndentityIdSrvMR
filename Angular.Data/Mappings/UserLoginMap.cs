using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AngularJs.Core.Modals;

namespace Angular.Data.Mappings
{
    class UserLoginMap : EntityTypeConfiguration<UserLogin>
    {
        public UserLoginMap()
        {
            this.ToTable("UserLogin");

            this.HasKey(u => new { u.UserId, u.LoginProvider, u.ProviderKey });

        }
    }
}
