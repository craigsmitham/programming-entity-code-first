using System.Data.Entity.ModelConfiguration;
using Model;

namespace DataAccess
{
    public class LodgingConfiguration : EntityTypeConfiguration<Lodging>
    {
        public LodgingConfiguration()
        {
            Property(l => l.Name).IsRequired().HasMaxLength(200);
            Property(l => l.MilesFromNearestAirport).HasPrecision(8, 1);
            // Changing the column name of a foreign key:
            Property(l => l.DestinationId).HasColumnName("destination_id");


            // Relationships
            HasOptional(l => l.PrimaryContact)
                .WithMany(p => p.PrimaryContactFor);

            HasOptional(l => l.SecondaryContact)
                .WithMany(p => p.SecondaryContactFor);

            HasRequired(l => l.Destination)
                .WithMany(d => d.Lodgings)
                .WillCascadeOnDelete(false);

        }
    }
}
