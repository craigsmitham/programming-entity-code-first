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
            Property(d => d.Description).HasMaxLength(500);
            Property(d => d.Photo).HasColumnType("image");



            // Relationships

            //ToTable("Locations", "baga");
            Map(m =>
                {
                    m.Properties(d => new { d.Name, d.Country, d.Description });
                    m.ToTable("Locations");
                });
            Map(m =>
                {
                    m.Properties(d => new { d.Photo });
                    m.ToTable("LocationPhotos");
                });

        }
    }
}
