using System;
using System.Collections.Generic;

namespace Model
{
    public class Person
    {
        public int PersonId { get; set; }
        public int SocialSecurityNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Address Address { get; set; }
        public PersonalInfo Info { get; set; }
        public byte[] RowVersion { get; set; }
        public List<Lodging> PrimaryContactFor { get; set; }
        public List<Lodging> SecondaryContactFor { get; set; }
        public PersonPhoto Photo { get; set; }
        public List<Reservation> Reservations { get; set; }
        

        // This will not be mapped to the database by EF because it has no setter
        public string FullName
        {
            get { return String.Format("{0} {1}", FirstName.Trim(), LastName.Trim()); }
        }
        

        public Person()
        {
            Address = new Address();
            Info = new PersonalInfo
            {
                Weight = new Measurement(),
                Height = new Measurement()
            };
        }


    }
}
