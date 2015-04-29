using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Angular.Core.Modals;
using Angular.Core.Modals.CustomerOrder;

namespace Angular.Data.Mappings
{
    public class TerritoryMap : EntityTypeConfiguration<Territory>
    {
        public TerritoryMap()
        {
            // Primary Key
            this.HasKey(t => t.TerritoryID);

            // Properties



            this.Property(t => t.TerritoryDescription)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Territories");
            this.Property(t => t.TerritoryID).HasColumnName("TerritoryID");
            this.Property(t => t.TerritoryDescription).HasColumnName("TerritoryDescription");
            this.Property(t => t.RegionID).HasColumnName("RegionID");

            // Relationships
            this.HasRequired(t => t.Region)
                .WithMany(t => t.Territories)
                .HasForeignKey(d => d.RegionID);

        }
    }
}
