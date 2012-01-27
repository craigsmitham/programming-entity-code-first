using System;
using System.Collections.Generic;

namespace Model
{
    public class Lodging
    {
        public int LodgingId { get; set; }
        public string Name { get; set; }
        public string Owner { get; set; }
        // public bool IsResort { get; set; }
        public decimal MilesFromNearestAirport { get; set; }

        public int DestinationId { get; set; }
        public Destination Destination { get; set; }

        public List<InternetSpecial> InternetSpecials { get; set; }

        public Nullable<int> PrimaryContactId { get; set; }
        public Person PrimaryContact { get; set; }
        public Nullable<int> SecondaryContactId { get; set; }
        public Person SecondaryContact { get; set; }
    }

    public class Resort : Lodging
    {
        public string Entertainment { get; set; }
        public string Activities { get; set; }
    }

    public class Hostel : Lodging
    {
        public int MaxPersonsPerRoom { get; set; }
        public bool PrivateRoomsAvailable { get; set; }
    }

}
