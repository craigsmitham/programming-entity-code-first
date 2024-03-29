﻿using System.Data.Entity;
using Model;

namespace DataAccess
{
    public class DropCreateBreakAwayWithSeedData :
        DropCreateDatabaseAlways<BreakAwayContext>
    {
        protected override void Seed(BreakAwayContext context)
        {
            context.Destinations.Add(new Destination { Name = "Great Barrier Reef" });
            context.Destinations.Add(new Destination { Name = "Grand Canyou" });
        }
    }
}
