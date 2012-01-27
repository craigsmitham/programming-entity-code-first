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
            
            // Relationships
            HasOptional(l => l.PrimaryContact)
                .WithMany(p => p.PrimaryContactFor);

            HasOptional(l => l.SecondaryContact)
                .WithMany(p => p.SecondaryContactFor);

            HasRequired(l => l.Destination)
                .WithMany(d => d.Lodgings)
                .WillCascadeOnDelete(false);

            


            Map(m =>
                {
                    // m.ToTable("Lodgings");
                    //m.Requires("IsResort").HasValue(false);
                })
                .Map<Resort>(m =>
                    {
                        //m.Requires("IsResort").HasValue(true);
                        m.ToTable("Resorts");
                    });
        }
    }
}
