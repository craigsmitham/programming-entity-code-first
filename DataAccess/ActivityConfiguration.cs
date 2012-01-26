using System.Data.Entity.ModelConfiguration;
using Model;

namespace DataAccess
{
    public class ActivityConfiguration : EntityTypeConfiguration<Activity>
    {
        public ActivityConfiguration()
        {
            Property(a => a.Name)
                .IsRequired()
                .HasMaxLength(50);
        }

    }
}
