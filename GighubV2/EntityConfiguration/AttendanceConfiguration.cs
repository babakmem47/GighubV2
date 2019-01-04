using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Web;
using GighubV2.Models;

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