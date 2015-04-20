
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Configuration;
using Angular.Core.Modals;
using Angular.Core.Modals.Identity;

namespace Angular.Data.Mappings
{
    public class UserMap: EntityTypeConfiguration<UserAccount>
    {
        public UserMap()
        {
            

        }

    }
}
