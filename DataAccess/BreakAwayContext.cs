using System;
using System.Data.Common;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using Model;

namespace DataAccess
{
    public class BreakAwayContext : DbContext
    {
        public BreakAwayContext()
        { }

        public BreakAwayContext(string databaseName)
            : base(databaseName)
        { }

        public BreakAwayContext(DbConnection connection)
            : base(connection, contextOwnsConnection: false)
        { }


        public DbSet<Destination> Destinations { get; set; }
        public DbSet<Lodging> Lodgings { get; set; }
        public DbSet<Trip> Trips { get; set; }
        public DbSet<Person> People { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Add Entity type configuration classes
            modelBuilder.Configurations.Add(new DestinationConfiguration());
            modelBuilder.Configurations.Add(new LodgingConfiguration());
            modelBuilder.Configurations.Add(new TripConfiguration());
            modelBuilder.Configurations.Add(new PersonConfiguration());
            modelBuilder.Configurations.Add(new PersonPhotoConfiguration());
            modelBuilder.Configurations.Add(new ReservationConfiguration());

            // Add Complex type configuration classes
            modelBuilder.Configurations.Add(new AddressConfiguration());
            modelBuilder.Configurations.Add(new PersonalInfoConfiguration());


            // In-line Entity configuration           
            modelBuilder.Entity<InternetSpecial>()
                .HasRequired(s => s.Accomodation)
                .WithMany(l => l.InternetSpecials)
                .HasForeignKey(s => s.AccomodationId);


        }
    }
}
