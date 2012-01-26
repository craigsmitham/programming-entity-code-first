using System.Data.Entity.ModelConfiguration;
using Model;

namespace DataAccess
{
    public class DestinationConfiguration : EntityTypeConfiguration<Destination> 
    {
        public DestinationConfiguration()
        {
            // Properties
            Property(d => d.Name).IsRequired();
            Property(d => d.Description).HasMaxLength(500);
            Property(d => d.Photo).HasColumnType("image");

            // Relationships
            //HasMany(d => d.Lodgings)
            //    .WithRequired(l => l.Destination);
        }
    }
}
