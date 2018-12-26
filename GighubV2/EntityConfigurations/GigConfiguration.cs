using GighubV2.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace GighubV2.EntityConfigurations
{
    public class GigConfiguration : EntityTypeConfiguration<Gig>
    {
        public GigConfiguration()
        {
            HasKey(gg => gg.Id);

            Property(g => g.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);


            Property(gg => gg.Venue)
                .IsRequired()
                .HasMaxLength(200);

            Property(gg => gg.Genre.Id)
                .IsRequired();

            Property(gg => gg.Artist.Id)
                .IsRequired();

            /////// Relation /////////////
            // Many-To-One With Genre
            HasRequired(gg => gg.Genre)
                .WithMany()
                .HasForeignKey(gg => gg.Genre.Id);

            // Many-To-One With AspNetUser
            HasRequired(gg => gg.Artist)
                .WithMany()
                .HasForeignKey(gg => gg.Artist.Id);

        }
    }
}