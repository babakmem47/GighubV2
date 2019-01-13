using GighubV2.Models;
using System.Data.Entity.ModelConfiguration;

namespace GighubV2.EntityConfiguration
{
    public class AttendanceConfiguration : EntityTypeConfiguration<Attendance>
    {
        public AttendanceConfiguration()
        {

            //// Many-To-One with Gig ////
            HasRequired(a => a.Gig)
                .WithMany()
                .WillCascadeOnDelete(false);
        }
    }

    public class ApplicationUserConfiguration : EntityTypeConfiguration<ApplicationUser>
    {
        public ApplicationUserConfiguration()
        {
            //// Relationship ////
            HasMany(u => u.Followers)
                .WithRequired(f => f.Followee)
                .WillCascadeOnDelete(false);

            HasMany(f => f.Followees)
                .WithRequired(u => u.Follower)
                .WillCascadeOnDelete(false);
        }
    }
}