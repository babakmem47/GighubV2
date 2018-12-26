using GighubV2.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace GighubV2.EntityConfigurations
{
    public class GenreConfiguration : EntityTypeConfiguration<Genre>
    {
        public GenreConfiguration()
        {
            HasKey(gn => gn.Id);

            Property(gn => gn.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(gn => gn.Name)
                .IsRequired();


            ///////// Relation /////////////
            //// One-To-Many With Gig /////


        }
    }
}