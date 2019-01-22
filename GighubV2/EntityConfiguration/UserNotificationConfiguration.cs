using System.Data.Entity.ModelConfiguration;
using GighubV2.Models;

namespace GighubV2.EntityConfiguration
{
    public class UserNotificationConfiguration : EntityTypeConfiguration<UserNotification>
    {
        public UserNotificationConfiguration()
        {
            HasRequired(un => un.User)
                .WithMany()
                .HasForeignKey(un => un.UserId)
                .WillCascadeOnDelete(false);
        }
    }
}