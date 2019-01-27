using GighubV2.Models;
using System.Data.Entity.ModelConfiguration;

namespace GighubV2.EntityConfiguration
{
    public class UserNotificationConfiguration : EntityTypeConfiguration<UserNotification>
    {
        public UserNotificationConfiguration()
        {
            HasRequired(un => un.User)
                .WithMany(n => n.UserNotifications)
                .HasForeignKey(un => un.UserId)
                .WillCascadeOnDelete(false);
        }
    }
}