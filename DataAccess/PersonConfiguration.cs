﻿using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations;
using Model;

namespace DataAccess
{
    public class PersonConfiguration : EntityTypeConfiguration<Person>
    {
        public PersonConfiguration()
        {
            Property(p => p.RowVersion).IsRowVersion();
            Property(p => p.SocialSecurityNumber).IsConcurrencyToken();
        }

    }
}
