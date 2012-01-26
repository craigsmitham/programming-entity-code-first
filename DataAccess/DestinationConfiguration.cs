using System.Data.Entity.ModelConfiguration;
using Model;

namespace DataAccess
{
    public class DestinationConfiguration : EntityTypeConfiguration<Destination> 
    {
        public DestinationConfiguration()
        {
            ToTable("Locations", "baga");

            // Properties
            Property(d => d.DestinationId)
                .HasColumnName("LocationID");
            Property(d => d.Name)
                .IsRequired()
                .HasColumnName("LocationName");
            Property(d => d.Description).HasMaxLength(500);
            Property(d => d.Photo).HasColumnType("image");



            // Relationships


        }
    }
}
