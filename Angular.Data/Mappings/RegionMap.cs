using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Angular.Core.Modals;
using Angular.Core.Modals.CustomerOrder;

namespace Angular.Data.Mappings
{
    public class RegionMap : EntityTypeConfiguration<Region>
    {
        public RegionMap()
        {
            // Primary Key
            this.HasKey(t => t.RegionID);

            // Properties
            this.Property(t => t.RegionID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.RegionDescription)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Region");
            this.Property(t => t.RegionID).HasColumnName("RegionID");
            this.Property(t => t.RegionDescription).HasColumnName("RegionDescription");
        }
    }
}
