using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations;
using Model;

namespace DataAccess
{
    public class PersonPhotoConfiguration : EntityTypeConfiguration<PersonPhoto>
    {
        public PersonPhotoConfiguration()
        {
            ToTable("People");

            HasKey(p => p.PersonId);

            HasRequired(p => p.PhotoOf)
                .WithRequiredDependent(p => p.Photo);   
        }

    }
}
