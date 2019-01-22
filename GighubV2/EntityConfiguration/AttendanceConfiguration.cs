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
}