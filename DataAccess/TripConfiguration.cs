﻿using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations;
using Model;

namespace DataAccess
{
    public class TripConfiguration : EntityTypeConfiguration<Trip>
    {
        public TripConfiguration()
        {
            // Table
            HasKey(t => t.Identifier);

            // Properties
            Property(t => t.Identifier)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(t => t.RowVersion).IsRowVersion();

            // Relationships
            HasMany(t => t.Activities)
                .WithMany(a => a.Trips)
                .Map(c =>
                    {
                        c.ToTable("TripActivities");
                        c.MapLeftKey("TripIdentifier");
                        c.MapRightKey("ActivityId");
                    });
        }

    }
}
