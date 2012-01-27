using System.Data.Entity.ModelConfiguration;
using Model;

namespace DataAccess
{
    public class DestinationConfiguration : EntityTypeConfiguration<Destination> 
    {
        public DestinationConfiguration()
        {
            
            // Properties
            Property(d => d.DestinationId)
                .HasColumnName("LocationID");
            Property(d => d.Name)
                .IsRequired()
                .HasColumnName("LocationName");
            // Testing new database initializer
            Property(d => d.Description).HasMaxLength(499);
            Property(d => d.Photo).HasColumnType("image");



            // Relationships


            // Custom table configuration
            ToTable("Locations", "baga");
        }
    }
}
