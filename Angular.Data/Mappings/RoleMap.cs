using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AngularJs.Core.Modals;

namespace Angular.Data.Mappings
{
    public class RoleMap: EntityTypeConfiguration<Role>
    {
        public RoleMap()
        {


            // Primary Key
            this.HasKey(t => t.Id)
                .Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            this.HasMany(t => t.Users)
                .WithRequired(t => t.Role)
                //.HasForeignKey(t => t.Role)
                .WillCascadeOnDelete(true);

            this.Property(r => r.Name)
                .HasMaxLength(50);

            this.ToTable("Role");
        }
    }
}
