﻿using System.Collections.Generic;

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

        

        public string FullName
        {
            get { return FirstName + " " + LastName; }
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
