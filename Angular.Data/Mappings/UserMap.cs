
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Configuration;
using AngularJs.Core.Modals;

namespace Angular.Data.Mappings
{
    public class UserMap: EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            
                       // Primary Key
            this.HasKey(t => t.Id)
                .Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

       
            this.Property(t => t.UserName)
                   .IsRequired()
                   .HasMaxLength(100);

            this.Property(t => t.Email)
                .IsRequired()
                .HasMaxLength(75);

            this.Property(u => u.PasswordHash)
                .HasMaxLength(200);

            this.Property(u => u.PhoneNumber)
                .HasMaxLength(20);

            this.Property(u => u.SecurityStamp)
                .HasMaxLength(200);

            this.HasMany(t => t.Roles)
                .WithRequired(t => t.User)
                .WillCascadeOnDelete(true);
            this.ToTable("User");
        }

    }
}
