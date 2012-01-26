using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations;
using Model;

namespace DataAccess
{
    public class TripConfiguration : EntityTypeConfiguration<Trip>
    {
        public TripConfiguration()
        {
            HasKey(t => t.Identifier);
            Property(t => t.Identifier)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(t => t.RowVersion).IsRowVersion();
        }

    }
}
